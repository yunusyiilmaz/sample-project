#pragma checksum "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0a4a24b046293d81d81012a84e10b9d289a5ffdb"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_Index), @"mvc.1.0.view", @"/Views/Customer/Index.cshtml")]
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
#line 1 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
using PROJE_OOP.Entity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0a4a24b046293d81d81012a84e10b9d289a5ffdb", @"/Views/Customer/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9438bffec90709cebb145a8cb67485b7c821512", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_CoreLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Müşteri Listesi</h1>\r\n<table class=\"table table-bordered\">\r\n    <tr>\r\n        <th>#</th>\r\n        <th>Müşteri Adı</th>\r\n        <th>Şehir</th>\r\n        <th>Ülke</th>\r\n        <th>Sil</th>\r\n        <th>Güncelle</th>\r\n    </tr>\r\n");
#nullable restore
#line 18 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
     foreach (var customer in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<tr>\r\n    <td>");
#nullable restore
#line 21 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
   Write(customer.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 22 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
   Write(customer.ContactName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 23 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
   Write(customer.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td>");
#nullable restore
#line 24 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
   Write(customer.Country);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 566, "\"", 618, 2);
            WriteAttributeValue("", 573, "/Customer/DeleteCustomer/", 573, 25, true);
#nullable restore
#line 25 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
WriteAttributeValue("", 598, customer.CustomerId, 598, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n    <td><a");
            BeginWriteAttribute("href", " href=\"", 667, "\"", 719, 2);
            WriteAttributeValue("", 674, "/Customer/UpdateCustomer/", 674, 25, true);
#nullable restore
#line 26 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"
WriteAttributeValue("", 699, customer.CustomerId, 699, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n</tr>\r\n");
#nullable restore
#line 28 "D:\Kişisel\Yunus\YAZILIM PROJE\Proje_OOP\Proje_OOP\PROJE_OOP\Views\Customer\Index.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/Customer/AddCustomer/\" class=\"btn btn-primary\">Müşteri Ekle</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
