#pragma checksum "/Users/phungquanghuy/Projects/AmazonWeb/AmazonWeb/Views/HomeAdmin/CreateProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f742ea4c4c7371998b9e23e3c7643f3697a39235"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HomeAdmin_CreateProduct), @"mvc.1.0.view", @"/Views/HomeAdmin/CreateProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f742ea4c4c7371998b9e23e3c7643f3697a39235", @"/Views/HomeAdmin/CreateProduct.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"648ea48261b2d986f86d9ea36d4c945c85c8ef4c", @"/Views/_ViewImports.cshtml")]
    public class Views_HomeAdmin_CreateProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 4 "/Users/phungquanghuy/Projects/AmazonWeb/AmazonWeb/Views/HomeAdmin/CreateProduct.cshtml"
  
    ViewData["Title"] = "Create Product";
    Layout = "_LayoutAdmin";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container-fluid\">\n    <div class=\"card\">\n        <div class=\"card-header\">\n            <h2>Thêm Sản Phẩm</h2>\n        </div>\n        <div class=\"card-body\">\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f742ea4c4c7371998b9e23e3c7643f3697a392354626", async() => {
                WriteLiteral("\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 504, "\"", 510, 0);
                EndWriteAttribute();
                WriteLiteral(">Loại sản phẩm</label>\n                    <select name=\"catalog_id\"");
                BeginWriteAttribute("id", " id=\"", 579, "\"", 584, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\">\n                    </select>\n                </div>\n\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 727, "\"", 733, 0);
                EndWriteAttribute();
                WriteLiteral(">Tên sản phẩm</label>\n                  <input type=\"text\" name=\"product_name\"");
                BeginWriteAttribute("id", " id=\"", 812, "\"", 817, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 839, "\"", 853, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\n                </div>\n\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 954, "\"", 960, 0);
                EndWriteAttribute();
                WriteLiteral(">Giá</label>\n                  <input type=\"number\" name=\"price\"");
                BeginWriteAttribute("id", " id=\"", 1025, "\"", 1030, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1052, "\"", 1066, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\n                </div>\n\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 1167, "\"", 1173, 0);
                EndWriteAttribute();
                WriteLiteral(">Nội dung</label>\n                  <input type=\"text\" name=\"content\"");
                BeginWriteAttribute("id", " id=\"", 1243, "\"", 1248, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1270, "\"", 1284, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\n                </div>\n\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 1385, "\"", 1391, 0);
                EndWriteAttribute();
                WriteLiteral(">Số lượng</label>\n                  <input type=\"number\" name=\"quantity\"");
                BeginWriteAttribute("id", " id=\"", 1464, "\"", 1469, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1491, "\"", 1505, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\n                </div>\n\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 1606, "\"", 1612, 0);
                EndWriteAttribute();
                WriteLiteral(">Giảm giá</label>\n                  <input type=\"number\" name=\"discount\"");
                BeginWriteAttribute("id", " id=\"", 1685, "\"", 1690, 0);
                EndWriteAttribute();
                WriteLiteral(" class=\"form-control\"");
                BeginWriteAttribute("placeholder", " placeholder=\"", 1712, "\"", 1726, 0);
                EndWriteAttribute();
                WriteLiteral(" required>\n                </div>\n\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 1827, "\"", 1833, 0);
                EndWriteAttribute();
                WriteLiteral(">Ảnh</label><br>\n                  <input type=\"file\" name=\"image_link\"");
                BeginWriteAttribute("id", " id=\"", 1905, "\"", 1910, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 1911, "\"", 1925, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n\n                <div class=\"form-group\">\n                  <label");
                BeginWriteAttribute("for", " for=\"", 2017, "\"", 2023, 0);
                EndWriteAttribute();
                WriteLiteral(">Danh sách ảnh</label><br>\n                  <input type=\"file\" name=\"image_list\"");
                BeginWriteAttribute("id", " id=\"", 2105, "\"", 2110, 0);
                EndWriteAttribute();
                BeginWriteAttribute("placeholder", " placeholder=\"", 2111, "\"", 2125, 0);
                EndWriteAttribute();
                WriteLiteral(">\n                </div>\n\n                <button name=\"sbm\" class=\"btn btn-success\" type=\"submit\">Thêm sản phẩm</button>\n            ");
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
            WriteLiteral("\n        </div>\n\n    </div>\n</div>");
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