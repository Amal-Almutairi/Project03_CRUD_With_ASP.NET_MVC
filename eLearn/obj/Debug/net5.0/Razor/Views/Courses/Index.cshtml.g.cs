#pragma checksum "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d36d506b7c5e1e7d2e6bc5a8664f9f0d0a353c2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Courses_Index), @"mvc.1.0.view", @"/Views/Courses/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d36d506b7c5e1e7d2e6bc5a8664f9f0d0a353c2", @"/Views/Courses/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325de8582b6d5f3967f01306b94e593dbc332b06", @"/Views/_ViewImports.cshtml")]
    public class Views_Courses_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"
  
    var Courses = (List<Course>)ViewData["Courses"];
    Layout = "_LayoutDesign";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<table class=\"table table-striped table-hover\" dir=\"rtl\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"
             foreach (var item in Courses)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card col-3\" style=\"width: 18rem;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 364, "\"", 387, 1);
#nullable restore
#line 16 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"
WriteAttributeValue("", 370, item.CourseImage, 370, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 409, "\"", 432, 1);
#nullable restore
#line 16 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"
WriteAttributeValue("", 415, item.CourseImage, 415, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"210px\" height=\"240px\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"
                                          Write(item.CourseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"
                                        Write(item.CourseLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        <div>\r\n                            <a");
            BeginWriteAttribute("href", " href=\"", 709, "\"", 742, 2);
            WriteAttributeValue("", 716, "/Courses/Details/", 716, 17, true);
#nullable restore
#line 21 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"
WriteAttributeValue(" ", 733, item.Id, 734, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary btn-color stretched-link\">Details</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 25 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Courses\Index.cshtml"

            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</table>");
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
