#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "983278841621baea51eda4b95fe91df93fee0a8f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SaleProduct), @"mvc.1.0.view", @"/Views/User/SaleProduct.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"983278841621baea51eda4b95fe91df93fee0a8f", @"/Views/User/SaleProduct.cshtml")]
    #nullable restore
    public class Views_User_SaleProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DressApp.WebUi.Data.Models.Product>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:80%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Like", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
  
    ViewData["Title"] = "SaleProduct";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<h3> İndirimli Ürünler</h3>
<hr />
<br />


<style>
    .checked {
        color: orange;
    }

    button.a:hover {
        background-color: navajowhite;
    }
</style>

<script src=""https://cdn.jsdelivr.net/npm/bootstrap@5.2.3/dist/js/bootstrap.bundle.min.js""></script>

<link rel=""stylesheet"" href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css"">

<div class=""container mt-3"">
    <div class=""row"">




");
#nullable restore
#line 34 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card hover2\" style=\"width:320px;height:460px;margin-bottom:20px;margin-right:-45px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "983278841621baea51eda4b95fe91df93fee0a8f7546", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 934, "~/img/", 934, 6, true);
#nullable restore
#line 38 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
AddHtmlAttributeValue("", 940, item.ProductImageUrl, 940, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div style=\"margin-top:10px;position:absolute;margin-left:180px;\">\r\n");
#nullable restore
#line 40 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                         if (item.StarNumber == 0)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
");
#nullable restore
#line 47 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                         if (item.StarNumber > 0 && item.StarNumber <= 20)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
");
#nullable restore
#line 55 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                         if (item.StarNumber > 20 && item.StarNumber <= 40)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
");
#nullable restore
#line 63 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 64 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                         if (item.StarNumber >= 40 && item.StarNumber <= 60)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star ""></span>
                            <span class=""fa fa-star ""></span>
");
#nullable restore
#line 71 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 71 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                           if (item.StarNumber > 60 && item.StarNumber <= 80)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star ""></span>
");
#nullable restore
#line 78 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 79 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                         if (item.StarNumber > 80)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
                            <span class=""fa fa-star checked""></span>
");
#nullable restore
#line 86 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </div>\r\n\r\n\r\n\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983278841621baea51eda4b95fe91df93fee0a8f15266", async() => {
                WriteLiteral(@"
                        <button title=""Favorilere Ekle"" class=""a btn btn-light"" style=""display:inline;position:absolute;margin-top:45px;margin-left:240px"" type=""submit"">  <img style=""width:30px;height:30px;margin-right:3px;"" src=""https://symbl-world.akamaized.net/i/webp/ce/7cdb1cae544d41f3c51f35ff8fcdf0.webp"" alt=""Siyah Kalp Kıyafeti""> </button>
                        <input type=""hidden"" name=""productId""");
                BeginWriteAttribute("value", " value=\"", 4365, "\"", 4388, 1);
#nullable restore
#line 94 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
WriteAttributeValue("", 4373, item.ProductId, 4373, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        <input type=\"hidden\" name=\"quantity\" value=\"1\">\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"






                    <div class=""card-body"">


                        <div class=""mb-3"">
                            <h6 class=""card-title ml-3"" style=""color:darkslateblue;margin-left:0px;""><p style=""display:inline;color:black;"">Ürün Adı: </p>");
#nullable restore
#line 107 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                                                                                                                                                     Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p style=\"display:inline;color:black;padding-left:4px;\">  <del style=\"margin-left:5px;margin-right:5px;\" class=\"price-old\">");
#nullable restore
#line 107 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                                                                                                                                                                                                                                                                                                       Write(item.SalePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("  <i class=\"fa fa-turkish-lira\" style=\"font-size:13px;padding-left:0px;\"></i></del> </p> ");
#nullable restore
#line 107 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                               Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-turkish-lira\" style=\"font-size:13px;\"></i></h6>\r\n\r\n\r\n\r\n\r\n                        </div>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5154, "\"", 5190, 2);
            WriteAttributeValue("", 5161, "/User/Details/", 5161, 14, true);
#nullable restore
#line 114 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
WriteAttributeValue("", 5175, item.ProductId, 5175, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary \" style=\"margin-right:10px;\">Detaylar</a>\r\n");
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "983278841621baea51eda4b95fe91df93fee0a8f21120", async() => {
                WriteLiteral("\r\n                            <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 5700, "\"", 5723, 1);
#nullable restore
#line 117 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
WriteAttributeValue("", 5708, item.ProductId, 5708, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                            <input type=\"hidden\" name=\"quantity\" value=\"1\">\r\n                            <button class=\"btn btn-outline-success w-20\" type=\"submit\">  <i class=\"fas fa-cart-plus\"></i> Sepete Ekle</button>\r\n\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n\r\n                    </div>\r\n                </div>\r\n\r\n                <br>\r\n            </div>\r\n");
#nullable restore
#line 130 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SaleProduct.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DressApp.WebUi.Data.Models.Product>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591