#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe1e0ba70a74176f77aaa55e282dd1568e1d11e9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_CreateRole), @"mvc.1.0.view", @"/Views/Account/CreateRole.cshtml")]
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
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml"
using DressApp.WebUi.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe1e0ba70a74176f77aaa55e282dd1568e1d11e9", @"/Views/Account/CreateRole.cshtml")]
    #nullable restore
    public class Views_Account_CreateRole : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RoleModel>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml"
  
    ViewData["Title"] = "CreateRole";
    Layout = "~/Views/Shared/_adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create Role</h1>\r\n\r\n\r\n");
#nullable restore
#line 12 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml"
 using (Html.BeginForm("CreateRole", "Account", FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml"
Write(Html.ValidationMessageFor(x=>x.RoleName,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 16 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml"
Write(Html.LabelFor(x=>x.RoleName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml"
Write(Html.TextBoxFor(x=>x.RoleName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
            WriteLiteral("      <button class=\"btn btn-primary\">Role Add</button>\r\n");
#nullable restore
#line 21 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Account\CreateRole.cshtml"

}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RoleModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
