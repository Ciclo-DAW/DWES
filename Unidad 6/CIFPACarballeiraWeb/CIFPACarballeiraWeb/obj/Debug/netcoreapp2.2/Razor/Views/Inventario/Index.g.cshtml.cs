#pragma checksum "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "591a7af0c1a8ffa08ddd22165ce9aeb9e602b6af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Index), @"mvc.1.0.view", @"/Views/Inventario/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventario/Index.cshtml", typeof(AspNetCore.Views_Inventario_Index))]
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
#line 1 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb;

#line default
#line hidden
#line 2 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb.Models;

#line default
#line hidden
#line 3 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"591a7af0c1a8ffa08ddd22165ce9aeb9e602b6af", @"/Views/Inventario/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203afd6339b2856fac0e6d1e2cb918836c78b87b", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CIFPACarballeiraWeb.Models.Material>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(57, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
  
    ViewData["Title"] = "Inventario";

#line default
#line hidden
            BeginContext(105, 34, true);
            WriteLiteral("\r\n<h2>Inventario</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(139, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591a7af0c1a8ffa08ddd22165ce9aeb9e602b6af5028", async() => {
                BeginContext(162, 50, true);
                WriteLiteral("<i class=\"fa fa-plus-circle\"></i> Alta de material");
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
            BeginContext(216, 154, true);
            WriteLiteral("\r\n</p>\r\n<table id=\"materials-table\" class=\"table table-striped table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(371, 42, false);
#line 16 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(413, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(469, 44, false);
#line 19 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.NumSerie));

#line default
#line hidden
            EndContext();
            BeginContext(513, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(569, 48, false);
#line 22 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(617, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(673, 44, false);
#line 25 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(717, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(773, 48, false);
#line 28 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(821, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(877, 45, false);
#line 31 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(922, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(978, 43, false);
#line 34 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.TipoUso));

#line default
#line hidden
            EndContext();
            BeginContext(1021, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 40 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1156, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1217, 41, false);
#line 44 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1258, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1326, 43, false);
#line 47 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.NumSerie));

#line default
#line hidden
            EndContext();
            BeginContext(1369, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1437, 47, false);
#line 50 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1484, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1552, 43, false);
#line 53 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1595, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1663, 54, false);
#line 56 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Departamento.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1717, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1785, 51, false);
#line 59 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Ubicacion.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1836, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1904, 42, false);
#line 62 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TipoUso));

#line default
#line hidden
            EndContext();
            BeginContext(1946, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2013, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591a7af0c1a8ffa08ddd22165ce9aeb9e602b6af13314", async() => {
                BeginContext(2058, 42, true);
                WriteLiteral("<i class=\"fas fa-edit\" title=\"Editar\"></i>");
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
#line 65 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
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
            BeginContext(2104, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2128, 99, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591a7af0c1a8ffa08ddd22165ce9aeb9e602b6af15732", async() => {
                BeginContext(2176, 47, true);
                WriteLiteral("<i class=\"fas fa-list-alt\" title=\"Detalle\"></i>");
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
#line 66 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
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
            BeginContext(2227, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2251, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "591a7af0c1a8ffa08ddd22165ce9aeb9e602b6af18159", async() => {
                BeginContext(2298, 49, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\" title=\"Eliminar\"></i>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
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
            BeginContext(2351, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 70 "D:\Documentos\FP\DWES\Unidad 6\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2406, 26, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(2450, 1618, true);
                WriteLiteral(@"
    <script type=""text/javascript"" src=""https://cdn.datatables.net/v/bs4/dt-1.10.18/datatables.min.js""></script>

    <script type=""text/javascript"">
        $(document).ready(function () {
            $('#materials-table').DataTable({
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
                    ""sLoadingRecords"": ""Car");
                WriteLiteral(@"gando..."",
                    ""oPaginate"": {
                        ""sFirst"": ""Primero"",
                        ""sLast"": ""Último"",
                        ""sNext"": ""Siguiente"",
                        ""sPrevious"": ""Anterior""
                    },
                    ""oAria"": {
                        ""sSortAscending"": "": Activar para ordenar la columna de manera ascendente"",
                        ""sSortDescending"": "": Activar para ordenar la columna de manera descendente""
                    }
                }
            }
            );
        });
    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CIFPACarballeiraWeb.Models.Material>> Html { get; private set; }
    }
}
#pragma warning restore 1591
