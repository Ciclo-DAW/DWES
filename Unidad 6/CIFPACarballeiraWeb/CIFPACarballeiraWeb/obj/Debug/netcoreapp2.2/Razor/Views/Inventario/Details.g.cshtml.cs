#pragma checksum "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "09464f4cb80f88d72790b3344abe1000e72e6634"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Inventario_Details), @"mvc.1.0.view", @"/Views/Inventario/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Inventario/Details.cshtml", typeof(AspNetCore.Views_Inventario_Details))]
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
#line 1 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb;

#line default
#line hidden
#line 2 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb.Models;

#line default
#line hidden
#line 3 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\_ViewImports.cshtml"
using CIFPACarballeiraWeb.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09464f4cb80f88d72790b3344abe1000e72e6634", @"/Views/Inventario/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"203afd6339b2856fac0e6d1e2cb918836c78b87b", @"/Views/_ViewImports.cshtml")]
    public class Views_Inventario_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CIFPACarballeiraWeb.Models.Material>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(44, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
  
    ViewData["Title"] = "Detalle de material";

#line default
#line hidden
            BeginContext(101, 120, true);
            WriteLiteral("\r\n<div>\r\n    <h4>Detalle de material</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(222, 42, false);
#line 12 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(264, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-7\">\r\n            ");
            EndContext();
            BeginContext(325, 38, false);
#line 15 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(363, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(424, 44, false);
#line 18 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumSerie));

#line default
#line hidden
            EndContext();
            BeginContext(468, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(529, 40, false);
#line 21 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumSerie));

#line default
#line hidden
            EndContext();
            BeginContext(569, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(632, 47, false);
#line 25 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(679, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(741, 43, false);
#line 28 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(784, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(847, 44, false);
#line 32 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(891, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(952, 40, false);
#line 35 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(992, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1053, 48, false);
#line 38 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1101, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(1162, 44, false);
#line 41 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoMaterial));

#line default
#line hidden
            EndContext();
            BeginContext(1206, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1267, 43, false);
#line 44 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoUso));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1371, 39, false);
#line 47 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoUso));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1473, 48, false);
#line 51 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Departamento));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1582, 51, false);
#line 54 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Departamento.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1633, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1694, 45, false);
#line 57 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(1739, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-3\">\r\n            ");
            EndContext();
            BeginContext(1800, 48, false);
#line 60 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ubicacion.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1848, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(1909, 42, false);
#line 63 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1951, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2012, 38, false);
#line 66 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(2050, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2113, 45, false);
#line 70 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Proveedor));

#line default
#line hidden
            EndContext();
            BeginContext(2158, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-4\">\r\n            ");
            EndContext();
            BeginContext(2219, 41, false);
#line 73 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.Proveedor));

#line default
#line hidden
            EndContext();
            BeginContext(2260, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2321, 50, false);
#line 76 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRecepcion));

#line default
#line hidden
            EndContext();
            BeginContext(2371, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(2432, 46, false);
#line 79 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaRecepcion));

#line default
#line hidden
            EndContext();
            BeginContext(2478, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2539, 49, false);
#line 82 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaRetirada));

#line default
#line hidden
            EndContext();
            BeginContext(2588, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(2649, 45, false);
#line 85 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaRetirada));

#line default
#line hidden
            EndContext();
            BeginContext(2694, 62, true);
            WriteLiteral("\r\n        </dd>\r\n\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2757, 49, false);
#line 89 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaGarantia));

#line default
#line hidden
            EndContext();
            BeginContext(2806, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-1\">\r\n            ");
            EndContext();
            BeginContext(2867, 45, false);
#line 92 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaGarantia));

#line default
#line hidden
            EndContext();
            BeginContext(2912, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2973, 48, false);
#line 95 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.InfoGarantia));

#line default
#line hidden
            EndContext();
            BeginContext(3021, 60, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-7\">\r\n            ");
            EndContext();
            BeginContext(3082, 44, false);
#line 98 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
       Write(Html.DisplayFor(model => model.InfoGarantia));

#line default
#line hidden
            EndContext();
            BeginContext(3126, 56, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n\r\n<br/>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(3182, 88, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09464f4cb80f88d72790b3344abe1000e72e663417036", async() => {
                BeginContext(3228, 38, true);
                WriteLiteral("<i class=\"fas fa-edit\"></i> Actualizar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 105 "C:\Users\VíctorManuel\Desktop\CIFPACarballeiraWeb\CIFPACarballeiraWeb\Views\Inventario\Details.cshtml"
                           WriteLiteral(Model.ID);

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
            BeginContext(3270, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(3278, 64, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "09464f4cb80f88d72790b3344abe1000e72e663419418", async() => {
                BeginContext(3300, 38, true);
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
            BeginContext(3342, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
