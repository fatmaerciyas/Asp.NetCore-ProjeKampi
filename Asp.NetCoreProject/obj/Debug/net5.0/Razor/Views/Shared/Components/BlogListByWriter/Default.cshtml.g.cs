#pragma checksum "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\BlogListByWriter\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5f264564f9da87c9d8d8b6044ff9b661c785bd23"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_BlogListByWriter_Default), @"mvc.1.0.view", @"/Views/Shared/Components/BlogListByWriter/Default.cshtml")]
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
#line 1 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\_ViewImports.cshtml"
using Asp.NetCoreProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\_ViewImports.cshtml"
using Asp.NetCoreProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\BlogListByWriter\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5f264564f9da87c9d8d8b6044ff9b661c785bd23", @"/Views/Shared/Components/BlogListByWriter/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9eb8e7b2b891a770993c30857c97343b76cd5e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_BlogListByWriter_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"tech-btm\">\r\n    <h4>Yazarın Diğer Yazıları</h4>\r\n");
#nullable restore
#line 7 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\BlogListByWriter\Default.cshtml"
     foreach (var item in Model)
    {



#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"blog-grids row mb-3\">\r\n            <div class=\"col-md-5 blog-grid-left\">\r\n                <a href=\"single.html\">\r\n                    <img");
            BeginWriteAttribute("src", " src=\"", 316, "\"", 337, 1);
#nullable restore
#line 14 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\BlogListByWriter\Default.cshtml"
WriteAttributeValue("", 322, item.BlogImage, 322, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid\"");
            BeginWriteAttribute("alt", " alt=\"", 356, "\"", 362, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </a>\r\n            </div>\r\n            <div class=\"col-md-7 blog-grid-right\">\r\n\r\n                <h5>\r\n                    <a href=\"single.html\">");
#nullable restore
#line 20 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\BlogListByWriter\Default.cshtml"
                                     Write(item.BlogTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </a>\r\n                </h5>\r\n                <div class=\"sub-meta\">\r\n                    <span>\r\n                        <i class=\"far fa-clock\"></i> ");
#nullable restore
#line 24 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\BlogListByWriter\Default.cshtml"
                                                 Write(((DateTime)item.BlogCreateDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </span>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
#nullable restore
#line 30 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\BlogListByWriter\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
