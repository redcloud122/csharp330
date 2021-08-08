#pragma checksum "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "16438c1549eda02528c6d9b80f53cec1f394d311"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_StudentClasses), @"mvc.1.0.view", @"/Views/Home/StudentClasses.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\_ViewImports.cshtml"
using TheLearningCenter;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\_ViewImports.cshtml"
using TheLearningCenter.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"16438c1549eda02528c6d9b80f53cec1f394d311", @"/Views/Home/StudentClasses.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de89341819a0c972b4ab3347e52715a550e80a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_StudentClasses : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheLearningCenter.Models.UserClassModel[]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EnrollInClass", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
  
    ViewData["Title"] = "Student Classes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .col1 {\r\n        text-align: left;\r\n    }\r\n\r\n    .col2 {\r\n        width: 40%;\r\n    }\r\n</style>\r\n\r\n<h1>");
#nullable restore
#line 17 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<hr />\r\n\r\n");
#nullable restore
#line 21 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
 if (Model.Length > 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row1\">\r\n        <div class=\"col1 font-weight-bold\">Name</div>\r\n        <div class=\"col2 font-weight-bold\">Description</div>\r\n        <div class=\"col font-weight-bold\">Paid</div>\r\n    </div>\r\n");
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 31 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row1\">\r\n            <div class=\"col1\">");
#nullable restore
#line 34 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
                         Write(item.MyClassModel.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col2\">");
#nullable restore
#line 35 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
                         Write(item.MyClassModel.ClassDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            <div class=\"col\">");
#nullable restore
#line 36 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
                        Write(item.MyClassModel.ClassPrice.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        </div>\r\n");
            WriteLiteral("        <hr />\r\n");
#nullable restore
#line 46 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 46 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>No class found.</p>\r\n");
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 53 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 56 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
 if (Model.Length == 4)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p><i>Congratulations! You have enrolled in all Learning Center\'s classes.</i></p>\r\n");
#nullable restore
#line 59 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
}
else if (Model.Length < 4)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "16438c1549eda02528c6d9b80f53cec1f394d3117397", async() => {
                WriteLiteral("Enroll in Class");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 63 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\StudentClasses.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheLearningCenter.Models.UserClassModel[]> Html { get; private set; }
    }
}
#pragma warning restore 1591