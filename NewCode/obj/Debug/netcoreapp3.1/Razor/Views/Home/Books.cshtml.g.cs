#pragma checksum "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "39569c0a8a01ea18248e161111bddd10c83fdbac"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Books), @"mvc.1.0.view", @"/Views/Home/Books.cshtml")]
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
#line 1 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\_ViewImports.cshtml"
using DemoMVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\_ViewImports.cshtml"
using DemoMVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"39569c0a8a01ea18248e161111bddd10c83fdbac", @"/Views/Home/Books.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b4f3640992204b1ab1edab80a3d884ce08f2b2b0", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Books : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<NewCode.Model.Books>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml"
  
    ViewData["Title"] = "Books";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>");
#nullable restore
#line 5 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n<table>\r\n    <thead>\r\n        <th>\r\n            BookName\r\n        </th>\r\n        <th>\r\n            Author\r\n        </th>\r\n        <th>\r\n            PAge\r\n        </th>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 20 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr><td>");
#nullable restore
#line 22 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml"
               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 22 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml"
                                  Write(item.Author);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td><td>");
#nullable restore
#line 22 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml"
                                                       Write(item.Page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td></tr>            \r\n");
#nullable restore
#line 23 "C:\Users\EE\Desktop\DemoMVC\NewCode\Views\Home\Books.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<NewCode.Model.Books>> Html { get; private set; }
    }
}
#pragma warning restore 1591
