#pragma checksum "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "65177eb737a78aa98a7427b1cbc4fd450fb2dec5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Departamentos_Index), @"mvc.1.0.view", @"/Views/Departamentos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Departamentos/Index.cshtml", typeof(AspNetCore.Views_Departamentos_Index))]
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
#line 1 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb;

#line default
#line hidden
#line 2 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65177eb737a78aa98a7427b1cbc4fd450fb2dec5", @"/Views/Departamentos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707f2ec26dbf3789099aa18759e63d54837711b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Departamentos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CIFPACarballeiraWeb.Models.Departamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml"
  
    ViewData["Title"] = "Departamentos";

#line default
#line hidden
            BeginContext(112, 46, true);
            WriteLiteral("\r\n<h1>Lista de departamentos</h1>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(158, 51, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65177eb737a78aa98a7427b1cbc4fd450fb2dec54635", async() => {
                BeginContext(181, 24, true);
                WriteLiteral("Crear nuevo departamento");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(209, 156, true);
            WriteLiteral("\r\n</p>\r\n<table id=\"departments-table\" class=\"table table-striped table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(366, 42, false);
#line 16 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(408, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 22 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(543, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(604, 41, false);
#line 26 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(645, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(712, 90, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65177eb737a78aa98a7427b1cbc4fd450fb2dec57520", async() => {
                BeginContext(757, 41, true);
                WriteLiteral("<i class=\"fa fa-edit\" title=\"Editar\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 29 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml"
                                           WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(802, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(826, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "65177eb737a78aa98a7427b1cbc4fd450fb2dec59948", async() => {
                BeginContext(873, 49, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\" title=\"Eliminar\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 30 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml"
                                             WriteLiteral(item.ID);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(926, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 33 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Departamentos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(981, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(1025, 1088, true);
                WriteLiteral(@"
    <script type=""text/javascript""
            src=""https://cdn.datatables.net/v/bs4/dt-1.10.18/datatables.min.js"">
    </script>
    <script type=""text/javascript"">
$(document).ready(function () {
$('#departments-table').DataTable({
language: {
""sProcessing"": ""Procesando..."",
""sLengthMenu"": ""Mostrar _MENU_ registros"",
""sZeroRecords"": ""No se encontraron resultados"",
""sEmptyTable"": ""Ningún dato disponible en esta tabla"",
""sInfo"": ""Mostrando registros del _START_ al _END_ de un total de _TOTAL_ registros"",
""sInfoEmpty"": ""Mostrando registros del 0 al 0 de un total de 0 registros"",
""sInfoFiltered"": ""(filtrado de un total de _MAX_ registros)"",
""sInfoPostFix"": """",
""sSearch"": ""Buscar:"",
""sUrl"": """",
""sInfoThousands"": "","",
""sLoadingRecords"": ""Cargando..."",
""oPaginate"": {
""sFirst"": ""Primero"",
""sLast"": ""Último"",
""sNext"": ""Siguiente"",
""sPrevious"": ""Anterior""
},
""oAria"": {
""sSortAscending"": "": Activar para ordenar la columna de manera ascendente"",
""sSortDescending"": "": Activar para ordenar la ");
                WriteLiteral("columna de manera descendente\"\r\n}\r\n}\r\n}\r\n);\r\n});\r\n    </script> ");
                EndContext();
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CIFPACarballeiraWeb.Models.Departamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
