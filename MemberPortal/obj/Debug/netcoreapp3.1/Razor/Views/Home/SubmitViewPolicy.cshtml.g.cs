#pragma checksum "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4027953b3e5e0d3b21559a94308d02e64e71133a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SubmitViewPolicy), @"mvc.1.0.view", @"/Views/Home/SubmitViewPolicy.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4027953b3e5e0d3b21559a94308d02e64e71133a", @"/Views/Home/SubmitViewPolicy.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b0e7e9dff134943c13dd742c7fdd6c01404a43be", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_SubmitViewPolicy : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MemberPortal.Models.MockDatabasePolicy>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
   ViewData["Title"] = "ViewPolicy";
    Layout = "~/Views/Home/_AdminLayout.cshtml";
    

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 7 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
 if (Model != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<table class=\"table\">\n    <thead>\n        <tr>\n            <th>\n                ");
#nullable restore
#line 13 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayName("PolictID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 16 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayName("PolicyNO"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 19 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayName("BenefitID"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 22 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayName("Premium"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            <th>\n                ");
#nullable restore
#line 25 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayName("Tenure"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </th>\n            \n            <th></th>\n        </tr>\n    </thead>\n    <tbody>\n        <tr>\n            <td>\n                ");
#nullable restore
#line 34 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayFor(model => model.PolicyID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 37 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayFor(model => model.PolicyNO));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 40 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayFor(model => model.BenefitID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 43 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayFor(model => model.Premium));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 46 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
           Write(Html.DisplayFor(model => model.Tenure));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            \n            <td>\n    </tbody>\n</table> \n");
#nullable restore
#line 52 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container\">\n        <div class=\"jumbotron\">\n            <h1 style=\"color:red;text-align:center\">No policy with this ID.</h1>\n        </div>\n    </div>\n    <h2></h2>\n");
#nullable restore
#line 61 "D:\DOWNLOADS\FIREFOX\Claims-Management-System(2)\ClaimManagementSystem-2\MemberPortal\Views\Home\SubmitViewPolicy.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MemberPortal.Models.MockDatabasePolicy> Html { get; private set; }
    }
}
#pragma warning restore 1591
