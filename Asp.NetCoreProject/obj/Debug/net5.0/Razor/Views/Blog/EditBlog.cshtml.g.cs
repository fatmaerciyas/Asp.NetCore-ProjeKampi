#pragma checksum "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5313c3a707d77153759f2ffba1b43210c8986178"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_EditBlog), @"mvc.1.0.view", @"/Views/Blog/EditBlog.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5313c3a707d77153759f2ffba1b43210c8986178", @"/Views/Blog/EditBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9eb8e7b2b891a770993c30857c97343b76cd5e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_EditBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Blog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
  
    ViewData["Title"] = "EditBlog";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
 using (Html.BeginForm("EditBlog", "Blog", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.Label("BlogID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 13 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Başlığı"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogTitle, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 16 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Thumbnail Url"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogThumbnailImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 19 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Görseli"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.TextBoxFor(x => x.BlogImage, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 22 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog Kategori ID"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.DropDownListFor(x => x.CategoryID, (List<SelectListItem>)ViewBag.cv, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n");
#nullable restore
#line 25 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.Label("Blog içeriği"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
Write(Html.TextAreaFor(x => x.BlogContent, 15, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <button class=\"btn btn-success\">Güncelle</button>\r\n");
#nullable restore
#line 29 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Blog\EditBlog.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
