#pragma checksum "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a25a395415bdd7d3228fd98dfd70c704c8b325fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Juegos_ListAll), @"mvc.1.0.view", @"/Views/Juegos/ListAll.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Juegos/ListAll.cshtml", typeof(AspNetCore.Views_Juegos_ListAll))]
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
#line 1 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore;

#line default
#line hidden
#line 2 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.Models;

#line default
#line hidden
#line 3 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\_ViewImports.cshtml"
using GameStore.ViewModels;

#line default
#line hidden
#line 2 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a25a395415bdd7d3228fd98dfd70c704c8b325fb", @"/Views/Juegos/ListAll.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf04f45a4f935101749f797ab3f22b80d09ea0a", @"/Views/_ViewImports.cshtml")]
    public class Views_Juegos_ListAll : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<GameStore.Models.Juego>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("boton-normal"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(173, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
  
    ViewData["Title"] = "Todos los juegos";

#line default
#line hidden
            BeginContext(227, 16, true);
            WriteLiteral("\r\n<h1>Todos los ");
            EndContext();
            BeginContext(244, 41, false);
#line 10 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
         Write(Html.DisplayFor(model => model[0].Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(285, 6, true);
            WriteLiteral(" para ");
            EndContext();
            BeginContext(292, 41, false);
#line 10 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
                                                         Write(Html.DisplayFor(model => model[0].Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(333, 36, true);
            WriteLiteral("</h1>\r\n\r\n<div class=\"items__list\">\r\n");
            EndContext();
#line 13 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
            BeginContext(410, 285, true);
            WriteLiteral(@"        <div class=""items__item"">
            <div class=""item__container"">
                <div class=""item__image"">

                </div>
                <div class=""item__text"">
                    <div class=""item__nombre"">
                        <h3 class=""item__marca"">");
            EndContext();
            BeginContext(696, 41, false);
#line 22 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
                                           Write(Html.DisplayFor(modelItem => item.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(737, 56, true);
            WriteLiteral("</h3>\r\n                        <h4 class=\"item__modelo\">");
            EndContext();
            BeginContext(794, 41, false);
#line 23 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
                                            Write(Html.DisplayFor(modelItem => item.Modelo));

#line default
#line hidden
            EndContext();
            BeginContext(835, 82, true);
            WriteLiteral("</h4>\r\n                    </div>\r\n                    <span class=\"item__precio\">");
            EndContext();
            BeginContext(918, 41, false);
#line 25 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
                                          Write(Html.DisplayFor(modelItem => item.Precio));

#line default
#line hidden
            EndContext();
            BeginContext(959, 51, true);
            WriteLiteral("€</span>\r\n                    <a class=\"item__link\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 1010, "\"", 1076, 2);
            WriteAttributeValue("", 1017, "http://", 1017, 7, true);
#line 26 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
WriteAttributeValue("", 1024, Html.DisplayFor(modelItem => item.Tienda.Direccion), 1024, 52, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1077, 27, true);
            WriteLiteral(">\r\n                        ");
            EndContext();
            BeginContext(1105, 48, false);
#line 27 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Tienda.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(1153, 120, true);
            WriteLiteral("\r\n                    </a>\r\n                    <div class=\"item__links\">                      \r\n                       ");
            EndContext();
            BeginContext(1273, 81, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a395415bdd7d3228fd98dfd70c704c8b325fb9239", async() => {
                BeginContext(1342, 8, true);
                WriteLiteral("Detalles");
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
#line 30 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
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
            BeginContext(1354, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 31 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
                         if (SignInManager.IsSignedIn(User))
                        {

#line default
#line hidden
            BeginContext(1445, 28, true);
            WriteLiteral("                            ");
            EndContext();
            BeginContext(1473, 76, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a395415bdd7d3228fd98dfd70c704c8b325fb12040", async() => {
                BeginContext(1539, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 33 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
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
            BeginContext(1549, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1579, 78, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a395415bdd7d3228fd98dfd70c704c8b325fb14522", async() => {
                BeginContext(1647, 6, true);
                WriteLiteral("Borrar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 34 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
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
            BeginContext(1657, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 35 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
                        }

#line default
#line hidden
            BeginContext(1686, 88, true);
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 40 "D:\Documentos\FP\DWES\Unidad 6\Proyecto\GameStore\GameStore\Views\Juegos\ListAll.cshtml"
    }

#line default
#line hidden
            BeginContext(1781, 21, true);
            WriteLiteral("</div>\r\n\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1802, 74, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a25a395415bdd7d3228fd98dfd70c704c8b325fb17598", async() => {
                BeginContext(1845, 27, true);
                WriteLiteral("Volver a la lista de juegos");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1876, 12, true);
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<GameStore.Models.Juego>> Html { get; private set; }
    }
}
#pragma warning restore 1591
