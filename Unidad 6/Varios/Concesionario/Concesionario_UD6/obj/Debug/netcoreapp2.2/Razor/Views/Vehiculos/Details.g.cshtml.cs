#pragma checksum "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1daa02885b89ae845331173a8cdabee876f4d68b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehiculos_Details), @"mvc.1.0.view", @"/Views/Vehiculos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Vehiculos/Details.cshtml", typeof(AspNetCore.Views_Vehiculos_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1daa02885b89ae845331173a8cdabee876f4d68b", @"/Views/Vehiculos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"314096816d6b795378a69a2c07f3b1193e213506", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehiculos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Concesionario_UD6.Models.Vehiculo>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(42, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
  
    ViewData["Title"] = "Información del vehículo";

#line default
#line hidden
            BeginContext(104, 40, true);
            WriteLiteral("\r\n<h4>Datos Vehículo</h4>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(144, 69, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daa02885b89ae845331173a8cdabee876f4d68b4463", async() => {
                BeginContext(166, 43, true);
                WriteLiteral(" <i class=\"fas fa-chevron-left\"></i> Voltar");
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
            BeginContext(213, 79, true);
            WriteLiteral("\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(293, 41, false);
#line 14 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(334, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(396, 37, false);
#line 17 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(433, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(494, 42, false);
#line 20 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(536, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(598, 38, false);
#line 23 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(636, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(697, 48, false);
#line 26 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.TipoVehiculo));

#line default
#line hidden
            EndContext();
            BeginContext(745, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(807, 44, false);
#line 29 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.TipoVehiculo));

#line default
#line hidden
            EndContext();
            BeginContext(851, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(912, 47, false);
#line 32 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Combustible));

#line default
#line hidden
            EndContext();
            BeginContext(959, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1021, 43, false);
#line 35 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Combustible));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1125, 42, false);
#line 38 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1167, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1229, 38, false);
#line 41 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1328, 47, false);
#line 44 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1375, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1437, 43, false);
#line 47 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1480, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1541, 47, false);
#line 50 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.NumBastidor));

#line default
#line hidden
            EndContext();
            BeginContext(1588, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1650, 43, false);
#line 53 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.NumBastidor));

#line default
#line hidden
            EndContext();
            BeginContext(1693, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1754, 49, false);
#line 56 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataRecepcion));

#line default
#line hidden
            EndContext();
            BeginContext(1803, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1865, 45, false);
#line 59 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataRecepcion));

#line default
#line hidden
            EndContext();
            BeginContext(1910, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1971, 45, false);
#line 62 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DataVenta));

#line default
#line hidden
            EndContext();
            BeginContext(2016, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2078, 41, false);
#line 65 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.DataVenta));

#line default
#line hidden
            EndContext();
            BeginContext(2119, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2180, 49, false);
#line 68 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Concesionario));

#line default
#line hidden
            EndContext();
            BeginContext(2229, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2291, 50, false);
#line 71 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Concesionario.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2341, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2402, 45, false);
#line 74 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Ubicacion));

#line default
#line hidden
            EndContext();
            BeginContext(2447, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2509, 46, false);
#line 77 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Ubicacion.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(2555, 47, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(2602, 103, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1daa02885b89ae845331173a8cdabee876f4d68b16906", async() => {
                BeginContext(2648, 53, true);
                WriteLiteral("<i class=\"fa fa-edit\" title=\"Editar\"></i>Editar datos");
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
#line 82 "C:\Users\marck\Desktop\CICLO DAW\DESENVOLVEMENTO WEB EN CONTORNO SERVIDOR\Tarefas\UD.6\Concesionario_UD6\Concesionario_UD6\Views\Vehiculos\Details.cshtml"
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
            BeginContext(2705, 10, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Concesionario_UD6.Models.Vehiculo> Html { get; private set; }
    }
}
#pragma warning restore 1591