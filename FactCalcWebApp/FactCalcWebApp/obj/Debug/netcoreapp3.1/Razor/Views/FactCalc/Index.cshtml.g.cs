#pragma checksum "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\FactCalc\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a100abcd97d89d9b828fd332172e8a13eff7e03"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_FactCalc_Index), @"mvc.1.0.view", @"/Views/FactCalc/Index.cshtml")]
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
#nullable restore
#line 1 "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\_ViewImports.cshtml"
using FactCalcWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\_ViewImports.cshtml"
using FactCalcWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a100abcd97d89d9b828fd332172e8a13eff7e03", @"/Views/FactCalc/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"df8a357515120388aaefe6895dcbbb1600cb23d7", @"/Views/_ViewImports.cshtml")]
    public class Views_FactCalc_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<FactCalcWebApp.Models.FactCalcModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\FactCalc\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Factorial</h1>\r\n\r\n<dl>\r\n    <h4>Calculate Factorial of any number</h4>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3a100abcd97d89d9b828fd332172e8a13eff7e033831", async() => {
                WriteLiteral("\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                Enter Any Number\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\FactCalc\Index.cshtml"
           Write(Html.TextBoxFor(model => model.InputFactNumber, new { @type = "number" ,@required = "required" }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </dd>
        </dl>
        <dl class=""row pl-5"">
            <dt class=""pr-4"">
                <input type=""submit"" value=""Calculate Factorial"" />
            </dt>
            <dd>
                <input type=""button"" value=""Clear"" onclick=""Clear();"" />
            </dd>
        </dl>
");
#nullable restore
#line 29 "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\FactCalc\Index.cshtml"
         if (Model != null)
        {

#line default
#line hidden
#nullable disable
                WriteLiteral("            <dl class=\"row\" id=\"resultDiv\">\r\n                <dt class=\"col-sm-2\">\r\n                    Calculated Factorial \r\n                </dt>\r\n                <dd class=\"col-sm-10\">\r\n                    ");
#nullable restore
#line 36 "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\FactCalc\Index.cshtml"
               Write(Html.DisplayFor(model => model.OutputFactNumber));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n");
#nullable restore
#line 39 "E:\KDP\FactCalcWebApp\FactCalcWebApp\Views\FactCalc\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
                WriteLiteral("    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</dl>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<FactCalcWebApp.Models.FactCalcModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
