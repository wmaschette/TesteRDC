#pragma checksum "C:\Users\Cliente\source\repos\DesafioRdc\DesafioRdc\Views\ProblemaSinais\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3448ad6c95b68124f2214dac007105db198e6802"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProblemaSinais_Index), @"mvc.1.0.view", @"/Views/ProblemaSinais/Index.cshtml")]
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
#line 1 "C:\Users\Cliente\source\repos\DesafioRdc\DesafioRdc\Views\_ViewImports.cshtml"
using DesafioRdc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Cliente\source\repos\DesafioRdc\DesafioRdc\Views\_ViewImports.cshtml"
using DesafioRdc.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3448ad6c95b68124f2214dac007105db198e6802", @"/Views/ProblemaSinais/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"058d029f54cc047cf626c8cddb7f76b4c2300438", @"/Views/_ViewImports.cshtml")]
    public class Views_ProblemaSinais_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Cliente\source\repos\DesafioRdc\DesafioRdc\Views\ProblemaSinais\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1 class=""text-center"">Resolvendo o Problema de Sinais</h1>
<br />
<div class=""row justify-content-center"">
    <input type=""text"" id=""InputSinais"" class=""input-group col-lg-4 col-md-6 col-sm-8 col-8"" placeholder=""Insira os sinais"" /> <input type=""button"" id=""Verifica"" class=""btn-dark"" onclick=""ValidarSinaisEntrada()"" value=""Validar"" />
</div>
<br />
<div id=""divResultado"">

</div>
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