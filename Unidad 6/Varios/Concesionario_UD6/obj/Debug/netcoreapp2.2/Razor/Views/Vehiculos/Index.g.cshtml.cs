#pragma checksum "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef5672e59e48a33c859ff02132e6eee8c516e116"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehiculos_Index), @"mvc.1.0.view", @"/Views/Vehiculos/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehiculos/Index.cshtml", typeof(AspNetCore.Views_Vehiculos_Index))]
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
#line 1 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\_ViewImports.cshtml"
using Concesionario_UD6;

#line default
#line hidden
#line 2 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\_ViewImports.cshtml"
using Concesionario_UD6.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef5672e59e48a33c859ff02132e6eee8c516e116", @"/Views/Vehiculos/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314096816d6b795378a69a2c07f3b1193e213506", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehiculos_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Concesionario_UD6.Models.Vehiculo>>
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
  
    ViewData["Title"] = "Vehículos";

#line default
#line hidden
            BeginContext(102, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            DefineSection("scripts", async() => {
                BeginContext(122, 1075, true);
                WriteLiteral(@"
    <script type=""text/javascript""
            src=""https://cdn.datatables.net/v/bs4/dt-1.10.18/datatables.min.js"">
    </script>
    <script type=""text/javascript"">
$(document).ready(function () {
$('#vehiculos-table').DataTable({
language: {
""sProcessing"": ""Procesando..."",
""sLengthMenu"": ""Amosar _MENU_ rexistros"",
""sZeroRecords"": ""Non se atoparon resultados"",
""sEmptyTable"": ""Non hai ningún dato dispoñible nesta táboa"",
""sInfo"": ""Amosando rexistros do _START_ ó _END_ dun total de _TOTAL_ rexistros"",
""sInfoEmpty"": ""Amosando rexistros do 0 ó 0 dun total de 0 rexistros"",
""sInfoFiltered"": ""(filtrado dun total de _MAX_ registros)"",
""sInfoPostFix"": """",
""sSearch"": ""Búsqueda:"",
""sUrl"": """",
""sInfoThousands"": "","",
""sLoadingRecords"": ""Cargando..."",
""oPaginate"": {
""sFirst"": ""Primeiro"",
""sLast"": ""Último"",
""sNext"": ""Seguinte"",
""sPrevious"": ""Previa""
},
""oAria"": {
""sSortAscending"": "": Activa para ordear a columna de maneira ascendente"",
""sSortDescending"": "": Activa para ordear a columna de manei");
                WriteLiteral("ra descendente\"\r\n}\r\n}\r\n}\r\n);\r\n});\r\n    </script> \r\n");
                EndContext();
            }
            );
            BeginContext(1200, 42, true);
            WriteLiteral("\r\n<h3>Vehículos en stock</h3>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(1242, 43, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5672e59e48a33c859ff02132e6eee8c516e1166559", async() => {
                BeginContext(1265, 16, true);
                WriteLiteral("Alta de vehículo");
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
            BeginContext(1285, 154, true);
            WriteLiteral("\r\n</p>\r\n<table id=\"vehiculos-table\" class=\"table table-striped table-bordered table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1440, 41, false);
#line 53 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(1481, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1537, 42, false);
#line 56 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(1579, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(1635, 42, false);
#line 59 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 65 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1812, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1873, 40, false);
#line 69 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(1913, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1981, 41, false);
#line 72 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(2022, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2090, 41, false);
#line 75 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2131, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2198, 82, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5672e59e48a33c859ff02132e6eee8c516e11611545", async() => {
                BeginContext(2243, 33, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i>Editar");
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
#line 78 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
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
            BeginContext(2280, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2304, 98, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5672e59e48a33c859ff02132e6eee8c516e11614003", async() => {
                BeginContext(2352, 46, true);
                WriteLiteral("<i class=\"fas fa-info-circle\"></i> Información");
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
#line 79 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
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
            BeginContext(2402, 24, true);
            WriteLiteral(" |\r\n                    ");
            EndContext();
            BeginContext(2426, 91, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef5672e59e48a33c859ff02132e6eee8c516e11616477", async() => {
                BeginContext(2473, 40, true);
                WriteLiteral("<i class=\"fas fa-trash-alt\"></i>Eliminar");
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
#line 80 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
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
            BeginContext(2517, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 83 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2572, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Concesionario_UD6.Models.Vehiculo>> Html { get; private set; }
    }
}
#pragma warning restore 1591
