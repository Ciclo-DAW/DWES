#pragma checksum "C:\Users\VíctorManuel\Desktop\Ejercicio\Ejercicio\Views\Home\Masked.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf35f7723dcfcf55c4a5ce8138955d092750e9e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Masked), @"mvc.1.0.view", @"/Views/Home/Masked.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Masked.cshtml", typeof(AspNetCore.Views_Home_Masked))]
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
#line 1 "C:\Users\VíctorManuel\Desktop\Ejercicio\Ejercicio\Views\_ViewImports.cshtml"
using Ejercicio;

#line default
#line hidden
#line 2 "C:\Users\VíctorManuel\Desktop\Ejercicio\Ejercicio\Views\_ViewImports.cshtml"
using Ejercicio.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cf35f7723dcfcf55c4a5ce8138955d092750e9e9", @"/Views/Home/Masked.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bb9f1ee37a5bae199b5e879d81e94bfcedfee1f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Masked : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<string>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\VíctorManuel\Desktop\Ejercicio\Ejercicio\Views\Home\Masked.cshtml"
  
    ViewData["Title"] = "Ejercicio 4.2.1 - Texto enmascarado";

#line default
#line hidden
            BeginContext(86, 37, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h2>");
            EndContext();
            BeginContext(124, 5, false);
#line 7 "C:\Users\VíctorManuel\Desktop\Ejercicio\Ejercicio\Views\Home\Masked.cshtml"
   Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(129, 17, true);
            WriteLiteral("</h2>\r\n    <h2>\r\n");
            EndContext();
#line 11 "C:\Users\VíctorManuel\Desktop\Ejercicio\Ejercicio\Views\Home\Masked.cshtml"
     foreach (var c in Model)
    {
        

#line default
#line hidden
            BeginContext(371, 1, true);
            WriteLiteral("*");
            EndContext();
#line 13 "C:\Users\VíctorManuel\Desktop\Ejercicio\Ejercicio\Views\Home\Masked.cshtml"
                      
    }

#line default
#line hidden
            BeginContext(388, 11, true);
            WriteLiteral("    </h2>\r\n");
            EndContext();
            BeginContext(621, 4, true);
            WriteLiteral("    ");
            EndContext();
            BeginContext(625, 46, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "cf35f7723dcfcf55c4a5ce8138955d092750e9e94640", async() => {
                BeginContext(647, 20, true);
                WriteLiteral("Volver al formulario");
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
            BeginContext(671, 8, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<string> Html { get; private set; }
    }
}
#pragma warning restore 1591
