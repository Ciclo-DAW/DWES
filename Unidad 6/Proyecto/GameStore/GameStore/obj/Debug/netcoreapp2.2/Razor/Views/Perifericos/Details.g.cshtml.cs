#pragma checksum "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "db17e2e8c44b9a33d957fe41df3068213f331026"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Perifericos_Details), @"mvc.1.0.view", @"/Views/Perifericos/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Perifericos/Details.cshtml", typeof(AspNetCore.Views_Perifericos_Details))]
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
#line 1 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore;

#line default
#line hidden
#line 2 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models;

#line default
#line hidden
#line 3 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.ViewModels;

#line default
#line hidden
#line 2 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"db17e2e8c44b9a33d957fe41df3068213f331026", @"/Views/Perifericos/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf04f45a4f935101749f797ab3f22b80d09ea0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Perifericos_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<GameStore.Models.Periferico>
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
            BeginContext(172, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
  
    ViewData["Title"] = "Detailles de periférico";

#line default
#line hidden
            BeginContext(233, 6, true);
            WriteLiteral("\r\n<h1>");
            EndContext();
            BeginContext(240, 44, false);
#line 10 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
Write(Html.DisplayFor(model => model.Marca.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(284, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(287, 38, false);
#line 10 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
                                              Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(325, 118, true);
            WriteLiteral("</h1>\r\n\r\n<div>\r\n    <h4>Periferico</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(444, 41, false);
#line 17 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Marca));

#line default
#line hidden
            EndContext();
            BeginContext(485, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(547, 44, false);
#line 20 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Marca.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(591, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(652, 42, false);
#line 23 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(694, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(756, 38, false);
#line 26 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(794, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(855, 47, false);
#line 29 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(902, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(964, 43, false);
#line 32 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Descripcion));

#line default
#line hidden
            EndContext();
            BeginContext(1007, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1068, 37, false);
#line 35 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.NameFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1105, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1167, 40, false);
#line 38 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Cantidad));

#line default
#line hidden
            EndContext();
            BeginContext(1207, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1268, 42, false);
#line 41 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1310, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1372, 38, false);
#line 44 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1471, 47, false);
#line 47 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FechaSalida));

#line default
#line hidden
            EndContext();
            BeginContext(1518, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1580, 43, false);
#line 50 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.FechaSalida));

#line default
#line hidden
            EndContext();
            BeginContext(1623, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1684, 42, false);
#line 53 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1726, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1788, 38, false);
#line 56 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Estado));

#line default
#line hidden
            EndContext();
            BeginContext(1826, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1887, 40, false);
#line 59 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(1927, 61, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1989, 36, false);
#line 62 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayFor(model => model.Tipo));

#line default
#line hidden
            EndContext();
            BeginContext(2025, 60, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(2086, 42, false);
#line 65 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Tienda));

#line default
#line hidden
            EndContext();
            BeginContext(2128, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2191, "\"", 2254, 2);
            WriteAttributeValue("", 2198, "http://", 2198, 7, true);
#line 68 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
WriteAttributeValue("", 2205, Html.DisplayFor(model => model.Tienda.Direccion), 2205, 49, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2255, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2257, 45, false);
#line 68 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
                                                                          Write(Html.DisplayFor(model => model.Tienda.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(2302, 47, true);
            WriteLiteral("</a>\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n");
            EndContext();
#line 73 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
     if (SignInManager.IsSignedIn(User))
    {

#line default
#line hidden
            BeginContext(2398, 8, true);
            WriteLiteral("        ");
            EndContext();
            BeginContext(2406, 77, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db17e2e8c44b9a33d957fe41df3068213f33102614736", async() => {
                BeginContext(2473, 6, true);
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
#line 75 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
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
            BeginContext(2483, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 76 "C:\Users\Brais\Documents\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Perifericos\Details.cshtml"
    }

#line default
#line hidden
            BeginContext(2492, 79, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db17e2e8c44b9a33d957fe41df3068213f33102617340", async() => {
                BeginContext(2535, 32, true);
                WriteLiteral("Volver a la lista de periféricos");
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
            BeginContext(2571, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<GameStore.Models.Periferico> Html { get; private set; }
    }
}
#pragma warning restore 1591
