#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e6edaa251f35570de2659064e869d2cfa6efbbf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Like_Index), @"mvc.1.0.view", @"/Views/Like/Index.cshtml")]
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
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
using DressApp.WebUi.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e6edaa251f35570de2659064e869d2cfa6efbbf", @"/Views/Like/Index.cshtml")]
    #nullable restore
    public class Views_Like_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<LikeModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Like", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteFromLike", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display:inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "AddToCart", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
 if (TempData["message"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"alert alert-success alert-dismissible fade show\" role=\"alert\">\r\n                <strong>");
#nullable restore
#line 13 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                   Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> İsimli Ürün Favorilere Eklendi!\r\n                <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 18 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
 if (TempData["messages"] != null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"alert alert-danger alert-dismissible fade show\" role=\"alert\">\r\n                <strong>");
#nullable restore
#line 24 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                   Write(TempData["messages"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> İsimli Ürün Favorilerden Silindi!\r\n                <button type=\"button\" class=\"btn-close\" data-bs-dismiss=\"alert\" aria-label=\"Close\"></button>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 29 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<section class=""h-100 h-custom"">
    <div class= ""ml-3 py-3 h-80"">
        <div class=""row d-flex justify-content-center align-items-center h-100"">
            <div class=""col-12"">
                <div class=""card card-registration card-registration-2""
                     style=""border-radius: 15px"">
                    <div class=""card-body p-0"">
                        <div class=""row g-0"">
                            <div class=""col-lg-10"">
                                <div class=""p-3"">
                                    <div class=""d-flex justify-content-between align-items-center mb-5"">
                                        <h1 class=""fw-bold mb-0 text-danger"">Favorilerim</h1>
                                        <h6 class=""mb-0 text-muted"">");
#nullable restore
#line 47 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                                               Write(Model.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(" Adet Ürün</h6>\r\n                                    </div>\r\n                                    <hr class=\"my-4\" />\r\n\r\n");
#nullable restore
#line 51 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                     if (@Model.Count() == 0)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <h6 style=\"color:red;\">Favorilerinizde Ürün Bulunmamaktadır!</h6>\r\n");
#nullable restore
#line 54 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 55 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                     foreach (var item in Model.LikeItems)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                        <div class=""row mb-4   align-items-center"">
                                            <div class=""col-md-1 col-lg-2 col-xl-2"">
                                                <img style=""width:100px;height:100px;""");
            BeginWriteAttribute("src", " src=\"", 2600, "\"", 2634, 2);
            WriteAttributeValue("", 2606, "/img/", 2606, 5, true);
#nullable restore
#line 59 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
WriteAttributeValue("", 2611, item.ProductSmallImage, 2611, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />
                                            </div>
                                            <div class=""col-md-1 col-lg-2 col-sm-2"">
                                                <h6 class=""text-muted"">Ürün Adı</h6>
                                                <h6 class=""text-black mb-0"">");
#nullable restore
#line 63 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                                                       Write(item.ProductSmallName);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                                 
                                            </div>
                                            <div class=""col-md-3 col-lg-2 col-l-1 "">
                                                <h6 class=""text-muted"">Beden/Num</h6>
                                                <h6 class=""mb-0"">");
#nullable restore
#line 68 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                                            Write(item.ProductSize);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </h6>

                                            </div>
                                         
                                            <div class=""col-md-1 col-lg-1 col-xl-1 "">
                                                <h6 class=""text-muted"">Fiyatı</h6>
                                                <h6 class=""mb-0"">");
#nullable restore
#line 74 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                                            Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(@" <i class=""fa fa-turkish-lira"" style=""font-size:13px;""></i></h6>
                                               
                                            </div>
                                            <div class=""col-md-1 col-lg-2 col-xl-2 offset-lg-1"">
                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e6edaa251f35570de2659064e869d2cfa6efbbf13034", async() => {
                WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4183, "\"", 4206, 1);
#nullable restore
#line 79 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
WriteAttributeValue("", 4191, item.ProductId, 4191, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <button type=""submit"" class=""btn btn-outline-danger btn-sm"">
                                                        <i class=""fa fa-heart me-1""> Favorilerden Sil</i>
                                                    </button>
                                                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                                </div>\r\n                                            <div class=\"col-md-1 col-lg-4 col-xl-2 \">\r\n                                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6e6edaa251f35570de2659064e869d2cfa6efbbf16018", async() => {
                WriteLiteral("\r\n                                                    <input type=\"hidden\" name=\"productId\"");
                BeginWriteAttribute("value", " value=\"", 4921, "\"", 4944, 1);
#nullable restore
#line 87 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
WriteAttributeValue("", 4929, item.ProductId, 4929, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(@">
                                                    <input type=""hidden"" name=""quantity"" value=""1"">
                                                    <button type=""submit"" class=""btn btn-outline-success btn-sm"">
                                                        <i class=""fas fa-cart-plus"" > Sepete Ekle</i>
                                                    </button>
                                                ");
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
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                                            </div>
                                            
                                            
                                            


                                          


                                        </div>
");
#nullable restore
#line 103 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\Like\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

                                    <hr class=""my-4"" />



                                    <div class=""pt-5"">
                                        <h6 class=""mb-0"">
                                            <a href=""/User/Page"" class=""btn btn-outline-danger"">
                                                Back
                                                to shop
                                            </a>
                                        </h6>
                                    </div>


                                </div>
                            </div>

                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<LikeModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591