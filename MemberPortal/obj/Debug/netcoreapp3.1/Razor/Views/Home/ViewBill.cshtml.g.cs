#pragma checksum "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3a6537e287872a6ef399f326dae8dcd1e1ba1c3f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewBill), @"mvc.1.0.view", @"/Views/Home/ViewBill.cshtml")]
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
#line 1 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\_ViewImports.cshtml"
using MemberPortal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\_ViewImports.cshtml"
using MemberPortal.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3a6537e287872a6ef399f326dae8dcd1e1ba1c3f", @"/Views/Home/ViewBill.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e7e9dff134943c13dd742c7fdd6c01404a43be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewBill : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberMicroservice.Models.MemberPremium>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
  
    ViewData["Title"] = "ViewBill";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table class=\"table\">\n        <thead>\n            <tr>\n                <th>\n                    ");
#nullable restore
#line 13 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayName("MemberID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 16 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayName("PolicyID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 19 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayName("PremiumDue"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 22 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayName("PaymentDetails"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 25 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayName("DueDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th>\n                    ");
#nullable restore
#line 28 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayName("LastPremiumPaidDate"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </th>\n                <th></th>\n            </tr>\n        </thead>\n        <tbody>\n            <tr>\n                <td>\n                    ");
#nullable restore
#line 36 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayFor(model => model.MemberID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 39 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayFor(model => model.PolicyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 42 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayFor(model => model.PremiumDue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 45 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayFor(model => model.PaymentDetails));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 48 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayFor(model => model.DueDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n                    ");
#nullable restore
#line 51 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
               Write(Html.DisplayFor(model => model.LastPremiumPaidDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                </td>\n                <td>\n        </tbody>\n    </table>\n");
#nullable restore
#line 56 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\n        <div class=\"jumbotron\">\n            <h1 style=\"color:red;text-align:center\" >No Policy  has been subscribed.</h1>\n        </div>\n    </div>\n    <h2></h2>\n");
#nullable restore
#line 65 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\ViewBill.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberMicroservice.Models.MemberPremium> Html { get; private set; }
    }
}
#pragma warning restore 1591
