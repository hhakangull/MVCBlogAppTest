#pragma checksum "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "59af9d0fd3254845fc3fb46b6fb3859b2a80d6bb"
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
#line 1 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\_ViewImports.cshtml"
using BlogApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\_ViewImports.cshtml"
using BlogApp.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\Home\Index.cshtml"
using System.IO;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"59af9d0fd3254845fc3fb46b6fb3859b2a80d6bb", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71e3104177def727f015b206df5ad61c9be818e7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\Home\Index.cshtml"
  
    Layout = "_homeLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""jumbotron-fluid jumbotron bg-gray"">
    <div class=""ml-3 pl-3 text-gray-dark"">
        <h1 class=""display-4"">Hello, world!</h1>
        <p class=""lead"">This is a simple hero unit, a simple jumbotron-style component for calling extra attention to featured content or information.</p>
        <hr class=""my-4"">
        <p>It uses utility classes for typography and spacing to space content out within the larger container.</p>
        <a class=""btn btn-primary btn-lg"" href=""#"" role=""button"">Learn more</a>
    </div>
</div>
<div class=""container"">
    <div class=""row"">
        <div class=""col-md-3"">
            ");
#nullable restore
#line 19 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\Home\Index.cshtml"
       Write(await Html.PartialAsync("_left_menu"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"col-md-9\">\r\n");
#nullable restore
#line 22 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\Home\Index.cshtml"
             foreach (var file in Directory.GetFiles("wwwroot/img", "*.jpg"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"card mb-3\">\r\n                    <h3 class=\"card-header\">Featured</h3>\r\n\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 1002, "\"", 1036, 1);
#nullable restore
#line 27 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\Home\Index.cshtml"
WriteAttributeValue("", 1008, file.Replace("wwwroot", ""), 1008, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""card-img-top img-fluid"" alt=""..."">
                    <div class=""card-body"">
                        <h5 class=""card-title"">Special title treatment</h5>
                        <p class=""card-text"">With supporting text below as a natural lead-in to additional content.</p>
                        <a href=""#"" class=""btn btn-primary"">Go somewhere</a>
                    </div>
                </div>
");
#nullable restore
#line 34 "C:\Users\Hakan\RiderProjects\BlogApp\BlogApp.Web\Views\Home\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n    </div>\r\n</div>");
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