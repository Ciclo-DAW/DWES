#pragma checksum "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b44636839f1e77f0ea389b359ef4789a4c4d4405"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Delete), @"mvc.1.0.view", @"/Views/Inventario/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventario/Delete.cshtml", typeof(AspNetCore.Views_Inventario_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b44636839f1e77f0ea389b359ef4789a4c4d4405", @"/Views/Inventario/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"707f2ec26dbf3789099aa18759e63d54837711b8", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIFPACarballeiraWeb.Models.Material>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
  
    ViewData["Title"] = "Baja del inventario"; 

#line default
#line hidden
            BeginContext(98, 176, true);
            WriteLiteral("<h3>Baja de inventario</h3>\r\n<h4>Estás seguro de eliminar el material del inventario?</h4>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(275, 42, false);
#line 10 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(317, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-7\">\r\n            ");
            EndContext();
            BeginContext(378, 38, false);
#line 13 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(416, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(477, 44, false);
#line 16 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NumSerie));

#line default
#line hidden
            EndContext();
            BeginContext(521, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(582, 40, false);
#line 19 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NumSerie));

#line default
#line hidden
            EndContext();
            BeginContext(622, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(683, 47, false);
#line 22 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(730, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(792, 43, false);
#line 25 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(835, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(896, 44, false);
#line 28 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(940, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(1001, 40, false);
#line 31 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1041, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1102, 48, false);
#line 34 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1150, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1211, 44, false);
#line 37 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1255, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1316, 43, false);
#line 40 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoUso));

#line default
#line hidden
            EndContext();
            BeginContext(1359, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1420, 39, false);
#line 43 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.TipoUso));

#line default
#line hidden
            EndContext();
            BeginContext(1459, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(1520, 42, false);
#line 46 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1562, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(1623, 38, false);
#line 49 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1661, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1722, 48, false);
#line 52 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1770, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(1831, 51, false);
#line 55 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Departamento.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1882, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1943, 45, false);
#line 58 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1988, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(2049, 48, false);
#line 61 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Ubicacion.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2097, 44, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    <br />\r\n    ");
            EndContext();
            BeginContext(2141, 245, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b44636839f1e77f0ea389b359ef4789a4c4d440513243", async() => {
                BeginContext(2167, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(2177, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b44636839f1e77f0ea389b359ef4789a4c4d440513636", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 66 "D:\Documentos\FP\DWES\Unidad 6\Ejercicios\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ID);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2213, 96, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Baja del inventario\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(2309, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b44636839f1e77f0ea389b359ef4789a4c4d440515588", async() => {
                    BeginContext(2331, 38, true);
                    WriteLiteral("<i class=\"fas fa-undo-alt\"></i> Volver");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2373, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2386, 8, true);
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CIFPACarballeiraWeb.Models.Material> Html { get; private set; }
    }
}
#pragma warning restore 1591