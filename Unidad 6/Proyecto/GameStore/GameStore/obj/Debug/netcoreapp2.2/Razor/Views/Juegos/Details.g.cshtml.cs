#pragma checksum "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2589ad485f0921b9f7399a501970ad415d3800b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juegos_Details), @"mvc.1.0.view", @"/Views/Juegos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Juegos/Details.cshtml", typeof(AspNetCore.Views_Juegos_Details))]
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
#line 1 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore;

#line default
#line hidden
#line 2 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models;

#line default
#line hidden
#line 3 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.ViewModels;

#line default
#line hidden
#line 2 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2589ad485f0921b9f7399a501970ad415d3800b", @"/Views/Juegos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf04f45a4f935101749f797ab3f22b80d09ea0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Juegos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameStore.Models.Juego>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boton-normal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(167, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
  
    ViewData["Title"] = "Detalles de juego";

#line default
#line hidden
            BeginContext(222, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(229, 38, false);
#line 10 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(267, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(270, 38, false);
#line 10 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
                                        Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(308, 113, true);
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>Juego</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(422, 42, false);
#line 17 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(464, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(526, 38, false);
#line 20 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(564, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(625, 42, false);
#line 23 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(667, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(729, 38, false);
#line 26 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(767, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(828, 47, false);
#line 29 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(875, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(937, 43, false);
#line 32 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(980, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1041, 37, false);
#line 35 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.NameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1078, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1140, 40, false);
#line 38 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1180, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1241, 42, false);
#line 41 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1283, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1345, 38, false);
#line 44 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1383, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1444, 47, false);
#line 47 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaSalida));

#line default
#line hidden
            EndContext();
            BeginContext(1491, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1553, 43, false);
#line 50 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaSalida));

#line default
#line hidden
            EndContext();
            BeginContext(1596, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1657, 42, false);
#line 53 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1699, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1761, 38, false);
#line 56 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1799, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1860, 42, false);
#line 59 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(1902, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1964, 38, false);
#line 62 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Genero));

#line default
#line hidden
            EndContext();
            BeginContext(2002, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2063, 42, false);
#line 65 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tienda));

#line default
#line hidden
            EndContext();
            BeginContext(2105, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(2167, 41, false);
#line 68 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tienda.ID));

#line default
#line hidden
            EndContext();
            BeginContext(2208, 43, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 73 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(2300, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2308, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2589ad485f0921b9f7399a501970ad415d3800b13872", async() => {
                BeginContext(2375, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 75 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
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
            BeginContext(2385, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "D:\Documentos\FP\DWES\Unidad 6\Backups\Proyecto\GameStore\GameStore\Views\Juegos\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2394, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2402, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2589ad485f0921b9f7399a501970ad415d3800b16568", async() => {
                BeginContext(2445, 27, true);
                WriteLiteral("Volver a la lista de juegos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2476, 14, true);
            WriteLiteral("\r\n    </div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameStore.Models.Juego> Html { get; private set; }
    }
}
#pragma warning restore 1591
