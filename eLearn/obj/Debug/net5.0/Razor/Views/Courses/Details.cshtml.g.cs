#pragma checksum "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ada3019e35c39e0230a6ab3f76af314a00ff2c84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Details), @"mvc.1.0.view", @"/Views/Courses/Details.cshtml")]
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
#line 1 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\_ViewImports.cshtml"
using eLearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\_ViewImports.cshtml"
using eLearn.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ada3019e35c39e0230a6ab3f76af314a00ff2c84", @"/Views/Courses/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325de8582b6d5f3967f01306b94e593dbc332b06", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Details.cshtml"
  
    var Course = (Course)ViewData["Details"];
    Layout = "_LayoutDesign";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"card mb-12\" style=\"margin-bottom:20px; margin-top:20px;\">\r\n    <div class=\"row g-0\">\r\n        <div class=\"col-md-4\">\r\n            <img");
            BeginWriteAttribute("src", " src=\"", 233, "\"", 258, 1);
#nullable restore
#line 9 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Details.cshtml"
WriteAttributeValue("", 239, Course.CourseImage, 239, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 259, "\"", 284, 1);
#nullable restore
#line 9 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Details.cshtml"
WriteAttributeValue("", 265, Course.CourseImage, 265, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"410px\" height=\"440px\">\r\n        </div>\r\n        <div class=\"col-md-8\">\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\" style=\"margin-top:7em\">");
#nullable restore
#line 13 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Details.cshtml"
                                                         Write(Course.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"card-text\">");
#nullable restore
#line 14 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Details.cshtml"
                                Write(Course.CourseDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                <p class=\"card-text\"><small class=\"text-muted\">");
#nullable restore
#line 15 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Details.cshtml"
                                                          Write(Course.CourseLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </small></p>\r\n                <a href=\"/Courses\" class=\"btn btn-primary btn-color\">Back</a>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
