#pragma checksum "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d45fa4258974004339030b8c16e0087a7c4d4d3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\_ViewImports.cshtml"
using PROJE_OOP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\_ViewImports.cshtml"
using PROJE_OOP.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
using PROJE_OOP.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d45fa4258974004339030b8c16e0087a7c4d4d3d", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9438bffec90709cebb145a8cb67485b7c821512", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CoreLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Ürün Sayfası</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n\r\n        <th>#</th>\r\n        <th>Ürün ADI</th>\r\n        <th>Miktar</th>\r\n        <th>Stok</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 19 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
     foreach (var product in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 22 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
   Write(product.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
   Write(product.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
   Write(product.UnityPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 25 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
   Write(product.StockAmount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 552, "\"", 593, 2);
            WriteAttributeValue("", 559, "/Product/DeleteProduct/", 559, 23, true);
#nullable restore
#line 26 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
WriteAttributeValue("", 582, product.Id, 582, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 642, "\"", 683, 2);
            WriteAttributeValue("", 649, "/Product/ProductUpdate/", 649, 23, true);
#nullable restore
#line 27 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
WriteAttributeValue("", 672, product.Id, 672, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n</tr>\r\n");
#nullable restore
#line 29 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Product\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Product/AddProduct/\" class=\"btn btn-primary\">Yeni ürün girişi</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
