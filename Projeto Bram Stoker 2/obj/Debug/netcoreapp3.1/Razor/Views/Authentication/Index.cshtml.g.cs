#pragma checksum "C:\Users\Vitor\Desktop\Projeto Bram Stoker 2\Projeto Bram Stoker 2\Views\Authentication\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "22107008e39fab2302c56418d9f2bb831e656829"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Authentication_Index), @"mvc.1.0.view", @"/Views/Authentication/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"22107008e39fab2302c56418d9f2bb831e656829", @"/Views/Authentication/Index.cshtml")]
    public class Views_Authentication_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<form action=\"/\" method=\"post\">\r\n\r\n    <input type=\"text\" name=\"usuario\"");
            BeginWriteAttribute("value", " value=\"", 76, "\"", 84, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n    <input type=\"text\" name=\"senha\"");
            BeginWriteAttribute("value", " value=\"", 125, "\"", 133, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n    <button data-action=\"Login\" data-url=\"");
#nullable restore
#line 8 "C:\Users\Vitor\Desktop\Projeto Bram Stoker 2\Projeto Bram Stoker 2\Views\Authentication\Index.cshtml"
                                     Write(Url.Action("Login", "Authentication"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Login</button>\r\n\r\n</form>\r\n\r\n<button data-action=\"Cadastrar\" data-url=\"");
#nullable restore
#line 12 "C:\Users\Vitor\Desktop\Projeto Bram Stoker 2\Projeto Bram Stoker 2\Views\Authentication\Index.cshtml"
                                     Write(Url.Action("Caadastrar", "Authentication"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">Cadastrar</button>


<script>
    $(document).on(""click"", '[data-action=""Login""]', function (e) {
        let 

        e.stopImmediatePropagation();
    })

    $(document).on(""click"", '[data-action=""Cadastrar""]', function (e) {

        e.stopImmediatePropagation();
    })


</script>
");
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
