#pragma checksum "D:\Studying\Năm 3\Lập trình WEB\doanweb - Copy\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Views\Shared\_TableButtonPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "179377b0ec5f5dd675e1b7c17abdae46024fa1fb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TableButtonPartial), @"mvc.1.0.view", @"/Views/Shared/_TableButtonPartial.cshtml")]
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
#line 1 "D:\Studying\Năm 3\Lập trình WEB\doanweb - Copy\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Views\_ViewImports.cshtml"
using WebBanHangMyPham;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Studying\Năm 3\Lập trình WEB\doanweb - Copy\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Views\_ViewImports.cshtml"
using WebBanHangMyPham.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"179377b0ec5f5dd675e1b7c17abdae46024fa1fb", @"/Views/Shared/_TableButtonPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"64f8d6e30aa8c9c313aea644133e4dc273a99aa4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TableButtonPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<td style=\"width:150px\">\r\n    <div class=\"btn-group\" role=\"group\">\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("hredf", " hredf=\"", 252, "\"", 305, 1);
#nullable restore
#line 8 "D:\Studying\Năm 3\Lập trình WEB\doanweb - Copy\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 260, Url.Action("EDIT/"+Model).Replace("%2F","/"), 260, 45, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fas fa-edit\"></i>\r\n        </a>\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("hredf", " hredf=\"", 412, "\"", 468, 1);
#nullable restore
#line 11 "D:\Studying\Năm 3\Lập trình WEB\doanweb - Copy\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 420, Url.Action("DETAILS/"+Model).Replace("%2F","/"), 420, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"fas fa-list-ul\"></i>\r\n        </a>\r\n        <a type=\"button\" class=\"btn btn-primary\"");
            BeginWriteAttribute("hredf", " hredf=\"", 578, "\"", 633, 1);
#nullable restore
#line 14 "D:\Studying\Năm 3\Lập trình WEB\doanweb - Copy\WEB_BAN_HANG_MY_PHAM\SourceCode\WebBanHangMyPham\WebBanHangMyPham\Views\Shared\_TableButtonPartial.cshtml"
WriteAttributeValue("", 586, Url.Action("DELETE/"+Model).Replace("%2F","/"), 586, 47, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <i class=\"far fa-trash-alt\"></i>\r\n        </a>\r\n    </div>\r\n</td>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
