#pragma checksum "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\Main\AmostrarResultado.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db406dc7de7327d7d6746842409a1ee58620807b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Main_AmostrarResultado), @"mvc.1.0.view", @"/Views/Main/AmostrarResultado.cshtml")]
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
#line 1 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\_ViewImports.cshtml"
using AlunoApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\_ViewImports.cshtml"
using AlunoApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db406dc7de7327d7d6746842409a1ee58620807b", @"/Views/Main/AmostrarResultado.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b570742181059c035aa95e17eb82766ae69fac61", @"/Views/_ViewImports.cshtml")]
    public class Views_Main_AmostrarResultado : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AlunoModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 9 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\Main\AmostrarResultado.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3>Resultado da pesquisa do aluno</h3>\r\n    <hr />\r\n");
            WriteLiteral("    <h4>Data de nascimento</h4>\r\n");
#nullable restore
#line 15 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\Main\AmostrarResultado.cshtml"
Write(Model.DataDeNascimento.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Nome</h4>\r\n");
#nullable restore
#line 18 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\Main\AmostrarResultado.cshtml"
Write(Model.Nome);

#line default
#line hidden
#nullable disable
            WriteLiteral("    <br />\r\n    <h4>Matricula</h4>\r\n");
#nullable restore
#line 21 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\Main\AmostrarResultado.cshtml"
Write(Model.Matricula);

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\Main\AmostrarResultado.cshtml"
Write(Html.ValidationSummary("", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 23 "D:\Users\lonascimento\Desktop\revisao\Nova pasta\AlunoApp\AlunoApp\AlunoApp\Views\Main\AmostrarResultado.cshtml"
                                                               

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AlunoModel> Html { get; private set; }
    }
}
#pragma warning restore 1591