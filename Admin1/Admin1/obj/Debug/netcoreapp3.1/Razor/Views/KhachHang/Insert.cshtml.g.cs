#pragma checksum "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f9fe95562e672a2ef3b384e52f8780e25ebe37c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_KhachHang_Insert), @"mvc.1.0.view", @"/Views/KhachHang/Insert.cshtml")]
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
#line 1 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\_ViewImports.cshtml"
using Admin1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\_ViewImports.cshtml"
using Admin1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9fe95562e672a2ef3b384e52f8780e25ebe37c6", @"/Views/KhachHang/Insert.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57b65c80033f464ac9668f1f836608e6f5be8585", @"/Views/_ViewImports.cshtml")]
    public class Views_KhachHang_Insert : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<KhachHang>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/KhachHang/Insert"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 1 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
  
    ViewData["Title"] = "Thêm Khách Hàng";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h3>Khách hàng</h3>\r\n\r\n");
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f9fe95562e672a2ef3b384e52f8780e25ebe37c64138", async() => {
                WriteLiteral("\r\n    <table>\r\n        <tr>\r\n            <td><label>Họ tên</label></td>\r\n            <td>");
#nullable restore
#line 13 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.hoten));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Địa chỉ</label></td>\r\n            <td>");
#nullable restore
#line 17 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.dchi));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Số điện thoại</label></td>\r\n            <td>");
#nullable restore
#line 21 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.sodt));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Ngày sinh</label></td>\r\n            <td>");
#nullable restore
#line 25 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.ngsinh));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Ngày đăng ký</label></td>\r\n            <td>");
#nullable restore
#line 29 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.ngdk));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Doanh số</label></td>\r\n            <td>");
#nullable restore
#line 33 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.doanhso));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Username</label></td>\r\n            <td>");
#nullable restore
#line 37 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.username));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Password</label></td>\r\n            <td>");
#nullable restore
#line 41 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.password));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td><label>Loại tài khoản</label></td>\r\n            <td>");
#nullable restore
#line 45 "H:\_FRAMEWORK\DoAn_QLBH_Framework\Admin1\Admin1\Views\KhachHang\Insert.cshtml"
           Write(Html.EditorFor(model => model.loaitk));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\" align=\"center\"><br /></td>\r\n        </tr>\r\n        <tr>\r\n            <td colspan=\"2\" align=\"center\"><input type=\"submit\" id=\"submit\" value=\"Thêm\" /></td>\r\n        </tr>\r\n    </table>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<KhachHang> Html { get; private set; }
    }
}
#pragma warning restore 1591
