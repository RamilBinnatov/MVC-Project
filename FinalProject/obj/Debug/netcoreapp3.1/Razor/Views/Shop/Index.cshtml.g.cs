#pragma checksum "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ec8794c6745469f53da2101d5c02e900e89f566a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shop_Index), @"mvc.1.0.view", @"/Views/Shop/Index.cshtml")]
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
#line 1 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\_ViewImports.cshtml"
using FinalProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\_ViewImports.cshtml"
using FinalProject.ViewModels.Account;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ec8794c6745469f53da2101d5c02e900e89f566a", @"/Views/Shop/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"edd5b74f3052de640e5d6a55b39f78c1d3a424fe", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shop_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShopVM>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ProductsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_defaultLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <div class=""single-category"">
        <div class=""container"">
            <div class=""wrapper"">
                <div class=""column"">
                    <div class=""holder"">
                        <div class=""row sidebar"">
                            <div class=""filter"">
                                <div class=""filter-block"">
                                    <h4>Category</h4>
                                    <ul>
");
#nullable restore
#line 19 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
                                         foreach (var item in Model.categories)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" name=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 823, "\"", 838, 1);
#nullable restore
#line 22 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 828, item.Name, 828, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <label");
            BeginWriteAttribute("for", " for=\"", 896, "\"", 912, 1);
#nullable restore
#line 23 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 902, item.Name, 902, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <span class=\"checked\"></span>\r\n                                                    <span>");
#nullable restore
#line 25 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </label>\r\n                                                <span class=\"count\"></span>\r\n                                            </li>\r\n");
#nullable restore
#line 29 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </div>\r\n\r\n                                <div class=\"filter-block\">\r\n                                    <h4>Brands</h4>\r\n                                    <ul>\r\n\r\n");
#nullable restore
#line 37 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
                                         foreach (var item in Model.Brands)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" name=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 1803, "\"", 1818, 1);
#nullable restore
#line 40 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 1808, item.Name, 1808, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <label");
            BeginWriteAttribute("for", " for=\"", 1876, "\"", 1892, 1);
#nullable restore
#line 41 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 1882, item.Name, 1882, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <span class=\"checked\"></span>\r\n                                                    <span>");
#nullable restore
#line 43 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </label>\r\n                                                <span class=\"count\"></span>\r\n                                            </li>\r\n");
#nullable restore
#line 47 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                    </ul>\r\n                                </div>\r\n\r\n                                <div class=\"filter-block\">\r\n                                    <h4>Brands</h4>\r\n                                    <ul>\r\n\r\n");
#nullable restore
#line 57 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
                                         foreach (var item in Model.Sizes)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li>\r\n                                                <input type=\"checkbox\" name=\"checkbox\"");
            BeginWriteAttribute("id", " id=\"", 2786, "\"", 2801, 1);
#nullable restore
#line 60 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2791, item.Name, 2791, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                <label");
            BeginWriteAttribute("for", " for=\"", 2859, "\"", 2875, 1);
#nullable restore
#line 61 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 2865, item.Name, 2865, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <span class=\"checked\"></span>\r\n                                                    <span>");
#nullable restore
#line 63 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                                </label>\r\n                                                <span class=\"count\"></span>\r\n                                            </li>\r\n");
#nullable restore
#line 67 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"

                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                    </ul>
                                </div>

                                <div class=""filter-block pricing"">
                                    <h4>Price</h4>
                                    <div class=""byprice"">
                                        <div class=""range-track"">
                                            <input type=""range"" class=""slider"" value=""25000"" min=""0""
                                                   max=""10000"">
                                        </div>
                                        <div class=""price-range"">
                                            <span class=""price-form"">$50</span>
                                            <span class=""price-to"">$500</span>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                        <div class=""section"">
 ");
            WriteLiteral(@"                           <div class=""row"">
                                <div class=""cat-head"">
                                    <div class=""breadcrumb"">
                                        <ul class=""flexitem"">

                                        </ul>
                                    </div>
                                    <div class=""page-title"">
                                        <h1>Shop</h1>
                                    </div>
                                    <div class=""cat-description"">
                                    </div>
                                    <div class=""cat-navigation flexitem"">
                                        <div class=""item-filter desktop-hide"">
                                            <a href=""#"" class=""filter-trigger label"">
                                                <i class=""ri-menu-2-line ri-2x""></i>
                                                <span>Filter</span>
                                   ");
            WriteLiteral(@"         </a>
                                        </div>

                                        <div class=""item-sortir"">
                                            <div class=""label"">
                                                <span class=""mobile-hide"">Sort by default</span>
                                                <div class=""desktop-hide"">Default</div>
                                                <i class=""ri-arrow-down-s-line""></i>
                                            </div>
                                            <ul>
                                                <li>Default</li>
                                                <li>Product Name</li>
                                                <li>Price</li>
                                                <li>Brand</li>
                                            </ul>
                                        </div>




                                    </div>

                                </");
            WriteLiteral("div>\r\n                            </div>\r\n                            <input type=\"hidden\" id=\"product-count\"");
            BeginWriteAttribute("value", " value=\"", 6451, "\"", 6473, 1);
#nullable restore
#line 130 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
WriteAttributeValue("", 6459, ViewBag.count, 6459, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                            <div class=\"products main flexwrap\" id=\"parent-products\">\r\n                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ec8794c6745469f53da2101d5c02e900e89f566a15289", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 132 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Products;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>
                            <div class=""load-more flexcenter"">
                                <button class=""secondary-button"">Show More</button>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <!-- Banners -->
    ");
#nullable restore
#line 145 "C:\Users\ramin\Desktop\FinalProject-HaqqqqVerdi\FinalProject\Views\Shop\Index.cshtml"
Write(await Component.InvokeAsync("Banner"));

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n\r\n\r\n\r\n</main>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShopVM> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
