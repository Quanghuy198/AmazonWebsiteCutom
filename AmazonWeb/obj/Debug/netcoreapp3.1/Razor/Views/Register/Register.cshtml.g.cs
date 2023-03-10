#pragma checksum "/Users/phungquanghuy/Projects/AmazonWeb/AmazonWeb/Views/Register/Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2e75b5678846a9a65c3f911f75ac274d28b8460"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Register_Register), @"mvc.1.0.view", @"/Views/Register/Register.cshtml")]
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
#line 1 "/Users/phungquanghuy/Projects/AmazonWeb/AmazonWeb/Views/_ViewImports.cshtml"
using AmazonWeb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/phungquanghuy/Projects/AmazonWeb/AmazonWeb/Views/_ViewImports.cshtml"
using AmazonWeb.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2e75b5678846a9a65c3f911f75ac274d28b8460", @"/Views/Register/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"648ea48261b2d986f86d9ea36d4c945c85c8ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_Register_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("index.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-login"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\n");
#nullable restore
#line 5 "/Users/phungquanghuy/Projects/AmazonWeb/AmazonWeb/Views/Register/Register.cshtml"
  
    ViewBag.Title = "Register";
    Layout = "~/Views/Shared/_LayoutRegister.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"wrap-login\">\n    <div class=\"wrap-form-login\">\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a2e75b5678846a9a65c3f911f75ac274d28b84604517", async() => {
                WriteLiteral(@"
            <h2 class=""header-form"">
                Create account
            </h2>
            <div class=""field"">
                <p class=""title-form"">Your name</p>
                <input type=""text"" class=""input-user"" id=""name"">
                <span class=""message"">
                    <i class=""ti-alert""></i>
                    <span class=""message-content"">Enter your name</span>
                </span>
            </div>

            <div class=""field"">
                <p class=""title-form"">Email</p>
                <input type=""text"" class=""input-user"" id=""email"">
                <span class=""message"">
                    <i class=""ti-alert""></i>
                    <span class=""message-content"">Enter your email</span>
                </span>
            </div>

            <div class=""field"">
                <p class=""title-form"">Password</p>
                <input type=""password"" class=""input-user"" id=""password"" placeholder=""At least 8 characters"">
                <span class=""message"">
        ");
                WriteLiteral(@"            <i class=""ti-alert""></i>
                    <span class=""message-content"">Enter your password</span>
                </span>
                <span class=""message-default"">
                    <i class=""ti-info-alt""></i>
                    <span class=""message-content"">Passwords must be at least 8 characters.</span>
                </span>
            </div>

            <div class=""field"">
                <p class=""title-form"">Re-enter password</p>
                <input type=""password"" class=""input-user"" id=""repassword"">
                <span class=""message"">
                    <i class=""ti-alert""></i>
                    <span class=""message-content"">Enter your re-password</span>
                </span>
            </div>

            <button type=""button"" class=""btn btn-sign-in"" id=""btn-register"">Create your Amamzon account</button>

            <span class=""legal-sig-in a-section"">
                By continuing, you agree to Amazon's
                <a href=""#"" class=""condition"">Conditions ");
                WriteLiteral(@"of Use</a>
                and
                <a href=""#"" class=""privacy"">Privacy Notice.</a>
            </span>

            <div class=""wrap-sign-in"">
                <div class=""sign-in a-section"">
                    <span>Already have an account?</span>
                    <a href=""#"" class=""link-sign-in"">Sign-In</a>
                </div>

                <div class=""sign-in a-section"">
                    <span>Purchasing for work?</span>
                    <a href=""#"" class=""link-sign-in"">Create a free business account</a>
                </div>
            </div>
        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
