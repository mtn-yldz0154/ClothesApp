#pragma checksum "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b65a0a6424f86c3bdb590961ff621c8e5016a022"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_SearchList), @"mvc.1.0.view", @"/Views/User/SearchList.cshtml")]
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
#line 1 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
using DressApp.WebUi.Data.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b65a0a6424f86c3bdb590961ff621c8e5016a022", @"/Views/User/SearchList.cshtml")]
    #nullable restore
    public class Views_User_SearchList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ProductSearchModel>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/carousel-18/carousel-18/css/style.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("hover"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top "), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:100%;height:80%;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
  
    ViewData["Title"] = "SearchList";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h6></h6>\r\n<hr />\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/4.7.0/css/font-awesome.min.css\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b65a0a6424f86c3bdb590961ff621c8e5016a0225572", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<style>\r\n    .checked {\r\n        color: orange;\r\n    }\r\n</style>\r\n\r\n\r\n");
#nullable restore
#line 21 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
 if(Model.Count==0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h3 class=\"alert alert-danger\">Aradığınız Kriterde Ürün Bulunmamaktadır!</h3>\r\n    <br /><br />\r\n");
#nullable restore
#line 25 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
}

#line default
#line hidden
#nullable disable
#nullable restore
#line 26 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
 foreach (var x in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h5> <h4 style=\"color:indianred;display:inline\">\'");
#nullable restore
#line 28 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                                                Write(x.q);

#line default
#line hidden
#nullable disable
            WriteLiteral("\'</h4> İle Çıkan Sonuçlar..</h5>  \n");
#nullable restore
#line 29 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
    break;
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<br /><br />\r\n\r\n<div class=\"container mt-3\">\r\n    <div class=\"row\">\r\n");
#nullable restore
#line 37 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
         foreach (var item in Model)
        {
            

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-md-4\">\r\n                <div class=\"card hover2\" style=\"width:320px;height:460px;margin-bottom:20px;margin-right:-45px;\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "b65a0a6424f86c3bdb590961ff621c8e5016a0228907", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1055, "~/img/", 1055, 6, true);
#nullable restore
#line 42 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
AddHtmlAttributeValue("", 1061, item.ProductImageUrl, 1061, 21, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    <div style=\"margin-top:10px;position:absolute;margin-left:180px;\">\r\n");
#nullable restore
#line 44 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
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
#line 51 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
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
#line 59 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 60 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
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
#line 67 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 68 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
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
#line 75 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 75 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
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
#line 82 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 83 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
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
#line 90 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                    </div>



                    <form asp-controller=""Like"" asp-action=""AddToLike"" method=""POST"" style=""display: inline;"">
                        <button title=""Favorilere Ekle"" class=""a btn btn-light"" style=""display:inline;position:absolute;margin-top:45px;margin-left:240px"" type=""submit"">  <img style=""width:30px;height:30px;margin-right:3px;"" src=""https://symbl-world.akamaized.net/i/webp/ce/7cdb1cae544d41f3c51f35ff8fcdf0.webp"" alt=""Siyah Kalp Kıyafeti""> </button>
                        <input type=""hidden"" name=""productId""");
            BeginWriteAttribute("value", " value=\"", 4486, "\"", 4509, 1);
#nullable restore
#line 98 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
WriteAttributeValue("", 4494, item.ProductId, 4494, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <input type=""hidden"" name=""quantity"" value=""1"">
                    </form>






                    <div class=""card-body"">


                        <div class=""mb-3"">
                            <h6 class=""card-title ml-3"" style=""color:darkslateblue;margin-left:0px;""><p style=""display:inline;color:black;"">Ürün Adı: </p>");
#nullable restore
#line 111 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                                                                                                                                                     Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("      <p style=\"display:inline;color:black;padding-left:4px;\"> Fiyat:</p> ");
#nullable restore
#line 111 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
                                                                                                                                                                                                                                                Write(item.ProductPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("<i class=\"fa fa-turkish-lira\" style=\"font-size:13px;\"></i></h6>\r\n\r\n\r\n\r\n\r\n                        </div>\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\"", 5116, "\"", 5152, 2);
            WriteAttributeValue("", 5123, "/User/Details/", 5123, 14, true);
#nullable restore
#line 118 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
WriteAttributeValue("", 5137, item.ProductId, 5137, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-primary \" style=\"margin-right:10px;\">Detaylar</a>\r\n");
            WriteLiteral("                        <form asp-controller=\"Cart\" asp-action=\"AddToCart\" method=\"POST\" style=\"display: inline;\">\r\n                            <input type=\"hidden\" name=\"productId\"");
            BeginWriteAttribute("value", " value=\"", 5662, "\"", 5685, 1);
#nullable restore
#line 121 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
WriteAttributeValue("", 5670, item.ProductId, 5670, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                            <input type=""hidden"" name=""quantity"" value=""1"">
                            <button class=""btn btn-outline-success w-20"" type=""submit"">  <i class=""fas fa-cart-plus""></i> Sepete Ekle</button>

                        </form>



                    </div>
                </div>

                <br>
            </div>
");
#nullable restore
#line 134 "C:\Users\Metin Yıldız\OneDrive - klu.edu.tr\Masaüstü\Alışveriş Sitesi\DressApp\DressApp.WebUi\DressApp.WebUi\Views\User\SearchList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ProductSearchModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
