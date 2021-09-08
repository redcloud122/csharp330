using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using UserService.Models;

namespace UserService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private static List<User> users = new List<User>();
        private static int currentId = 101;

        // 1. POST to add a user and return a 201 Created
        [HttpPost]
        public IActionResult Post([FromBody] User user)
        {
            if (user == null)
            {
                return new BadRequestResult();
            }

            string msg = "";

            if (String.IsNullOrEmpty(user.Email))
            {
                msg = "Email field is null or empty";
            }

            if (String.IsNullOrEmpty(user.Password))
            {
                if (String.IsNullOrEmpty(msg))
                {
                    msg = "Password field is null or empty";
                }
                else
                {
                    msg = "Both Email and password fields are null or empty";
                }
            }

            if (!String.IsNullOrEmpty(msg))
            {
                return BadRequest(new ErrorResponse { Message = msg, Data = user });
            }

            user.Id = currentId++;
            user.DateCreated = DateTime.Now;

            users.Add(user);

            return CreatedAtAction(nameof(Get), new { id = user.Id }, user);
        }

        // 2. PUT to update a user and return a 200 OK
        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] User user)
        {
            var myUser = users.FirstOrDefault(t => t.Id == id);

            if (myUser == null)
            {
                return NotFound();
            }

            myUser.Email = user.Email;
            myUser.Password = user.Password;

            return Ok(myUser);
        }

        // 3. GET to get all users
        [HttpGet]
        public IActionResult Get()
        {
            return Ok(users);
        }

        // 4. GET to get a single user
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var myUser = users.FirstOrDefault(t => t.Id == id);

            if (myUser == null)
            {
                return new NotFoundResult();
            }

            return Ok(myUser);
        }

        // 5. DELETE to delete a single user and return a 200 or 404 if the user is not found
        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var usersDeleted = users.RemoveAll(t => t.Id == id);

            if (usersDeleted == 0)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}
