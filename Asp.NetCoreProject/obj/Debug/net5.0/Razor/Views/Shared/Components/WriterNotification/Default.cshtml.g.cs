#pragma checksum "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c674cd632facb439bbfabce261075e4180a21b53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_WriterNotification_Default), @"mvc.1.0.view", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
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
#line 1 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c674cd632facb439bbfabce261075e4180a21b53", @"/Views/Shared/Components/WriterNotification/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9eb8e7b2b891a770993c30857c97343b76cd5e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_WriterNotification_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Notification>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"dropdown-menu dropdown-menu-right navbar-dropdown preview-list\" aria-labelledby=\"notificationDropdown\">\r\n    <h6 class=\"p-3 mb-0\">Bildirimler</h6>\r\n");
#nullable restore
#line 5 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"dropdown-divider\"></div>\r\n        <a class=\"dropdown-item preview-item\">\r\n            <div class=\"preview-thumbnail\">\r\n                <div");
            BeginWriteAttribute("class", " class=\"", 416, "\"", 448, 1);
#nullable restore
#line 10 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue(" ", 424, item.NotificationColor, 425, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\r\n                    <i");
            BeginWriteAttribute("class", " class=\"", 476, "\"", 512, 1);
#nullable restore
#line 12 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml"
WriteAttributeValue("", 484, item.NotificationTypeSymbol, 484, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("></i>\r\n                </div>\r\n            </div>\r\n            <div class=\"preview-item-content d-flex align-items-start flex-column justify-content-center\">\r\n                <h6 class=\"preview-subject font-weight-normal mb-1\">");
#nullable restore
#line 16 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml"
                                                               Write(item.NotificationType);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <p class=\"text-gray ellipsis mb-0\"> ");
#nullable restore
#line 17 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml"
                                               Write(item.NotificationDetails);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </p>\r\n            </div>\r\n        </a>\r\n");
#nullable restore
#line 20 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Shared\Components\WriterNotification\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n    <div class=\"dropdown-divider\"></div>\r\n    <h6 class=\"p-3 mb-0 text-center\"><a href=\"/Notification/Index\">T??m bildirimleri g??r</a></h6>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Notification>> Html { get; private set; }
    }
}
#pragma warning restore 1591
