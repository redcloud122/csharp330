using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using TheLearningCenter.Models;
using Microsoft.AspNetCore.Http;
using LearningCenterBusiness;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using System.Security.Claims;
using Newtonsoft.Json;
using Microsoft.AspNetCore.Authorization;

namespace TheLearningCenter.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IClassManager _classManager;
        private readonly IUserManager _userManager;
        private readonly IUserClassManager _userClassManager;

        public HomeController(ILogger<HomeController> logger, IClassManager classManager, IUserManager userManager, IUserClassManager userClassManager)
        {
            _logger = logger;
            this._classManager = classManager;
            this._userManager = userManager;
            this._userClassManager = userClassManager;
        }

        public IActionResult Index()
        {
            return View();
        }

        [Authorize]
        public IActionResult EnrollInClass()
        {
            var user = JsonConvert.DeserializeObject<Models.UserModel>(HttpContext.Session.GetString("Email"));

            UserClassListModel model = new UserClassListModel();

            model.UserId = user.Id;

            var classes = _userClassManager.GetUnEnrolledClasses(user.Id)
                .Select(t => new Models.ShortClassListItem { ClassId = t.ClassId, ClassName = t.ClassName}).ToArray();

            model.ClassList = classes;

            return View(model);
        }

        [HttpPost]
        public IActionResult EnrollInClass(UserClassListModel userClassListModel)
        {
            var user = JsonConvert.DeserializeObject<Models.UserModel>(HttpContext.Session.GetString("Email"));

            var model = _userClassManager.AddClass(userClassListModel.ClassId, user.Id);

            return RedirectToAction("EnrollInClass");
        }

        [Authorize]
        public IActionResult StudentClasses()
        {
            var user = JsonConvert.DeserializeObject<Models.UserModel>(HttpContext.Session.GetString("Email"));

            var studentClasses = _userClassManager.GetEnrolledClasses(user.Id)
                .Select(t => new Models.UserClassModel
                {
                    UserId = t.UserId,
                    MyClassModel = new Models.ClassModel(t.ClassId, t.ClassName, t.ClassDescription, t.ClassPrice)
                }).ToArray();

            return View(studentClasses);
        }

        [HttpGet]
        public IActionResult Login()
        {
            ViewData["ReturnUrl"] = Request.Query["returnUrl"];
            return View();
        }

        [HttpPost]
        public IActionResult Login(LoginModel loginModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                var user = _userManager.LogIn(loginModel.Email, loginModel.Password);

                if (user == null)
                {
                    ModelState.AddModelError("", "Invalid credential");
                }
                else
                {
                    // old working code
                    //HttpContext.Session.SetString("Email", loginModel.Email);
                    //return RedirectToAction("ClassList");

                    var json = JsonConvert.SerializeObject(new Models.UserModel
                    {
                        Id = user.Id,
                        Email = user.Email
                    });

                    HttpContext.Session.SetString("Email", json);

                    var claims = new List<Claim>
                    {
                        new Claim(ClaimTypes.Email, user.Email),
                        new Claim(ClaimTypes.Role, "User"),
                    };

                    var claimsIdentity = new ClaimsIdentity(claims,
                        CookieAuthenticationDefaults.AuthenticationScheme);

                    var claimsPrincipal = new ClaimsPrincipal(claimsIdentity);

                    var authProperties = new AuthenticationProperties
                    {
                        AllowRefresh = false,
                        // Refreshing the authentication session should be allowed.

                        ExpiresUtc = DateTimeOffset.UtcNow.AddMinutes(10),
                        // The time at which the authentication ticket expires. A 
                        // value set here overrides the ExpireTimeSpan option of 
                        // CookieAuthenticationOptions set with AddCookie.

                        IsPersistent = false,
                        // Whether the authentication session is persisted across 
                        // multiple requests. When used with cookies, controls
                        // whether the cookie's lifetime is absolute (matching the
                        // lifetime of the authentication ticket) or session-based.

                        IssuedUtc = DateTimeOffset.UtcNow,
                        // The time at which the authentication ticket was issued.
                    };

                    HttpContext.SignInAsync(
                        CookieAuthenticationDefaults.AuthenticationScheme,
                        claimsPrincipal,
                        authProperties).Wait();

                    return Redirect(returnUrl ?? "~/");
                }
            }

            ViewData["ReturnUrl"] = returnUrl;

            return View(loginModel);
        }

        public IActionResult ClassList()
        {
            var classes = _classManager.Classes
                .Select(t => new Models.ClassModel(t.ClassId, t.ClassName, t.ClassDescription, t.ClassPrice))
                .ToArray();

            ViewBag.TotalNumOfClasses = classes.Length;

            var model = new ClassListModel { Classes = classes };
            return View(model);
        }

        public IActionResult About()
        {
            return View();
        }


        public IActionResult Contact()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Register()
        {
            var register = new RegisterModel { };
            return View(register);
        }

        [HttpPost]
        public IActionResult Register(RegisterModel registerModel, string returnUrl)
        {
            if (ModelState.IsValid)
            {
                if (registerModel.ArePasswordsSame())
                {
                    bool isUserNameTaken = true;

                    var register = _userManager.Register(registerModel.Email, registerModel.Password, ref isUserNameTaken);

                    if (isUserNameTaken)
                    {
                        ModelState.AddModelError("", "Invalid registration:  User name is already taken;  Pleae choose a different email as user name.");
                    }
                    else
                    {
                        if (register == null)
                        {
                            ModelState.AddModelError("", "Invalid registration.  Email is sent to the Learning Center developer for troubleshooting.");
                        }
                        else
                        {
                            return View("Thanks", registerModel);
                        }
                    }
                }
                else
                {
                    ModelState.AddModelError("", "Your passwords mismatch; Please re-enter and confirm.");
                }
            }

            ViewData["ReturnUrl"] = returnUrl;

            return View(registerModel);
        }


        public IActionResult Logoff()
        {

            HttpContext.Session.Remove("Email");

            HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);

            return Redirect("~/");
        }

    }
}
