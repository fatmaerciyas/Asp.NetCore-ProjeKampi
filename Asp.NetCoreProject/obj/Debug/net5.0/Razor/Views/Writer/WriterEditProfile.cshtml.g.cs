#pragma checksum "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49385473e27b3ee4792b494e99c86871ca32a19b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Writer_WriterEditProfile), @"mvc.1.0.view", @"/Views/Writer/WriterEditProfile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49385473e27b3ee4792b494e99c86871ca32a19b", @"/Views/Writer/WriterEditProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9eb8e7b2b891a770993c30857c97343b76cd5e3", @"/Views/_ViewImports.cshtml")]
    public class Views_Writer_WriterEditProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntityLayer.Concrete.Writer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("forms-sample"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
  
    ViewData["Title"] = "WriterEditProfile";
    Layout = "~/Views/Shared/_WriterLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
 using (Html.BeginForm("WriterEditProfile", "Writer", FormMethod.Post))
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"col-12 grid-margin stretch-card\">\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <p>");
#nullable restore
#line 14 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
              Write(ViewBag.a);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 15 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
                 if (ViewBag.a == 1)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <h6>Bilgileriniz G??ncellendi</h6>\r\n");
#nullable restore
#line 18 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                <br />\r\n                <h4 class=\"card-title\">Yazar Profil Bilgileri D??zenleme</h4>\r\n                ");
#nullable restore
#line 21 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
           Write(Html.HiddenFor(x => x.WriterID, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                <br />\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49385473e27b3ee4792b494e99c86871ca32a19b5814", async() => {
                WriteLiteral("\r\n\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputName1\">Ad Soyad</label>\r\n\r\n                        ");
#nullable restore
#line 28 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputEmail3\">Mail</label>\r\n                        ");
#nullable restore
#line 32 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextBoxFor(x => x.WriterMail, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <label for=\"exampleInputPassword4\">??ifre</label>\r\n                        ");
#nullable restore
#line 36 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.PasswordFor(x => x.WriterPassword, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
                    </div>

                    <div class=""form-group"">
                        <label>Yazar Profil Foto??raf??</label>
                        <input type=""file"" name=""img[]"" class=""file-upload-default"">
                        <div class=""input-group col-xs-12"">
                            <input type=""text"" class=""form-control file-upload-info"" disabled placeholder=""Upload Image"">
                            <span class=""input-group-append"">
                                <button class=""file-upload-browse btn btn-gradient-primary"" type=""button"">G??rsel Y??kle</button>
                            </span>
                        </div>
                    </div>

                    <div class=""form-group"">
                        <label for=""exampleTextarea1"">Hakk??mda</label>
                        ");
#nullable restore
#line 52 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"
                   Write(Html.TextAreaFor(x => x.WriterAbout, 10, 3, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </div>\r\n                    <button type=\"submit\" class=\"btn btn-gradient-primary mr-2\">De??i??iklikleri Kaydet</button>\r\n                    <button class=\"btn btn-light\">??ptal</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 60 "C:\Users\fatma\Desktop\Asp.NetCore-ProjeKampi-master\Asp.NetCoreProject\Views\Writer\WriterEditProfile.cshtml"

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntityLayer.Concrete.Writer> Html { get; private set; }
    }
}
#pragma warning restore 1591
