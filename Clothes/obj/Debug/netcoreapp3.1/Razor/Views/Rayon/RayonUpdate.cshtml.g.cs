#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4449c9fe4e4b60724b0c56fad53cf37109da0106"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rayon_RayonUpdate), @"mvc.1.0.view", @"/Views/Rayon/RayonUpdate.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4449c9fe4e4b60724b0c56fad53cf37109da0106", @"/Views/Rayon/RayonUpdate.cshtml")]
    #nullable restore
    public class Views_Rayon_RayonUpdate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DressApp.WebUi.Data.Models.Rayon>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
  
    ViewData["Title"] = "RayonUpdate";
    Layout = "~/Views/Shared/_adminlayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Rayon Update</h1>\r\n<hr />\r\n<br />\r\n\r\n");
#nullable restore
#line 11 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
 using (Html.BeginForm("RayonUpdate", "Rayon", FormMethod.Post))
{
  
 
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
Write(Html.LabelFor(x=>x.RayonId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
Write(Html.TextBoxFor(x=>x.RayonId,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
Write(Html.ValidationMessageFor(x=>x.RayonName,"",new{@style="color:red"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 21 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
Write(Html.LabelFor(x=>x.RayonName));

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
Write(Html.TextBoxFor(x=>x.RayonName,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n");
#nullable restore
#line 24 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
Write(Html.LabelFor(x=>x.RayonDescription));

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"
Write(Html.TextBoxFor(x=>x.RayonDescription,new {@class="form-control"}));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <br />\r\n      <button class=\"btn btn-primary\">Rayon Update</button>\r\n");
#nullable restore
#line 28 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Dedektor\Views\Rayon\RayonUpdate.cshtml"

}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DressApp.WebUi.Data.Models.Rayon> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591