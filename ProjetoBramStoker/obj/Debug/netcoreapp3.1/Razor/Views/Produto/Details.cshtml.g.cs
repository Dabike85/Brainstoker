#pragma checksum "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5669937dbb5322d292ca47003ef4f226525aab51"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Produto_Details), @"mvc.1.0.view", @"/Views/Produto/Details.cshtml")]
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
#line 1 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\_ViewImports.cshtml"
using ProjetoBramStoker;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\_ViewImports.cshtml"
using ProjetoBramStoker.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5669937dbb5322d292ca47003ef4f226525aab51", @"/Views/Produto/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"98e7e31186a76c3316f923e78bd6172439877f63", @"/Views/_ViewImports.cshtml")]
    public class Views_Produto_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ProjetoBramStoker.ViewModels.ProdutoViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Produto", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "PegarConfirm", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary btn-block"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
   
    Layout = "_Layout";;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""mb-5"" style=""margin: 10px"">
    <div class=""row"">
        <div class=""col-md-6 mb-4 mb-md-0"">
            <div id=""mdb-lightbox-ui""></div>

            <div class=""mdb-lightbox"">
                <div class=""row product-gallery mx-1"">
                    <div class=""col-12 mb-0"">
                        <figure class=""view overlay rounded z-depth-1 main-img"">
                            <img");
            BeginWriteAttribute("src", " src=\"", 512, "\"", 531, 1);
#nullable restore
#line 17 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
WriteAttributeValue("", 518, Model.Imagem, 518, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"img-fluid z-depth-1\">\r\n                        </figure>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n        <div class=\"col-md-6\">\r\n            <h5>");
#nullable restore
#line 25 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
           Write(Model.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n            <p class=\"mb-2 text-muted text-uppercase small\">Shirts</p>\r\n            <p><span class=\"mr-1\"><strong>Gratis</strong></span></p>\r\n            <p class=\"pt-1\">\r\n                ");
#nullable restore
#line 29 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
           Write(Model.Descricao);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
            </p>
            <div class=""table-responsive"">
                <table class=""table table-sm table-borderless mb-0"">
                    <tbody>
                        <tr>
                            <th class=""pl-0 w-25"" scope=""row""><strong>Modelo</strong></th>
                            <td>");
#nullable restore
#line 36 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
                           Write(Model.Modelo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n                        <tr>\r\n                            <th class=\"pl-0 w-25\" scope=\"row\"><strong>Cor</strong></th>\r\n                            <td>");
#nullable restore
#line 40 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
                           Write(Model.Cor);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        </tr>\r\n");
            WriteLiteral("                    </tbody>\r\n                </table>\r\n            </div>\r\n            <hr>\r\n");
#nullable restore
#line 50 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
               
                var dict = new Dictionary<string, string>();
                dict.Add("produtoId", Model.ProdutoID.ToString());
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5669937dbb5322d292ca47003ef4f226525aab517692", async() => {
                WriteLiteral("Pegar Agora");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
#nullable restore
#line 54 "C:\Users\Pichau\Desktop\Projeto Bram Stoker 2\ProjetoBramStoker\Views\Produto\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues = dict;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-all-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ProjetoBramStoker.ViewModels.ProdutoViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591