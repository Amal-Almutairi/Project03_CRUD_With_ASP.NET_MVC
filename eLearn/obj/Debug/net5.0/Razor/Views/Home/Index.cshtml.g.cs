#pragma checksum "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a500b3a1a8f03ed04ceeca1097860016e1baf0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a500b3a1a8f03ed04ceeca1097860016e1baf0", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"325de8582b6d5f3967f01306b94e593dbc332b06", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml"
  
    var Categories = (List<Category>)ViewData["Categories"];
    Layout = "_LayoutDesign";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n<table class=\"table table-striped table-hover\">\r\n    <div class=\"container\" style=\"padding-left:250px !important;\">\r\n        <div class=\"row\" style=\" margin-top: 30px;\">\r\n\r\n");
#nullable restore
#line 12 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml"
             foreach (var item in Categories)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card col-4\" style=\"width: 18rem;\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 431, "\"", 456, 1);
#nullable restore
#line 16 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml"
WriteAttributeValue("", 437, item.CategoryImage, 437, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img-top\"");
            BeginWriteAttribute("alt", " alt=\"", 478, "\"", 503, 1);
#nullable restore
#line 16 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml"
WriteAttributeValue("", 484, item.CategoryImage, 484, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"210px\" height=\"240px\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">");
#nullable restore
#line 18 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml"
                                          Write(item.CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 19 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml"
                                        Write(item.CategoryDescription);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 22 "C:\Users\amalf\OneDrive\Desktop\Tuwaiq\.Net\Projects\Project02_EF_ASP.NET_MVC\eLearn\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("            <a href=\"/Courses/\" class=\"btn btn-primary btn-color stretched-link\">More</a>\r\n        </div>\r\n    </div>\r\n</table>");
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
