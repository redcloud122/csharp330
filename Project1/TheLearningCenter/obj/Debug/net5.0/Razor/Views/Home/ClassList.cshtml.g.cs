#pragma checksum "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5c9e328a33fc51e870e83330dd5db799c69eb0eb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ClassList), @"mvc.1.0.view", @"/Views/Home/ClassList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5c9e328a33fc51e870e83330dd5db799c69eb0eb", @"/Views/Home/ClassList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4de89341819a0c972b4ab3347e52715a550e80a3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ClassList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TheLearningCenter.Models.ClassListModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml"
  
    ViewData["Title"] = "Classes";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<style>\r\n    .col1 {\r\n        text-align: left;\r\n    }\r\n\r\n    .col2 {\r\n        width: 40%;\r\n    }\r\n</style>\r\n\r\n<h1>");
#nullable restore
#line 17 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<hr />\r\n\r\n<div class=\"row1\">\r\n    <div class=\"col1 font-weight-bold\">Name</div>\r\n    <div class=\"col2 font-weight-bold\">Description</div>\r\n    <div class=\"col font-weight-bold\">Price</div>\r\n</div>\r\n\r\n<hr />\r\n\r\n");
#nullable restore
#line 29 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml"
 foreach (var item in Model.Classes)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row1\">\r\n        <div class=\"col1\">");
#nullable restore
#line 32 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml"
                     Write(item.ClassName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col2\">");
#nullable restore
#line 33 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml"
                     Write(item.ClassDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n        <div class=\"col\">");
#nullable restore
#line 34 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml"
                    Write(item.ClassPrice.ToString("C"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n    </div>\r\n");
            WriteLiteral("    <hr />\r\n");
#nullable restore
#line 38 "C:\Users\qa853c\Documents\1_Learning\UW\C#\330\Project1\TheLearningCenter\Views\Home\ClassList.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TheLearningCenter.Models.ClassListModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
