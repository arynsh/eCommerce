#pragma checksum "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23f104ce87c69e4fa4d5862336dba9c455757522"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Products_Create), @"mvc.1.0.view", @"/Views/Products/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Products/Create.cshtml", typeof(AspNetCore.Views_Products_Create))]
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
#line 1 "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23f104ce87c69e4fa4d5862336dba9c455757522", @"/Views/Products/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Views/_ViewImports.cshtml")]
    public class Views_Products_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Ecommerce.Models.Product>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(28, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(61, 27, true);
            WriteLiteral("\n<h4>Add a new flavor</h4>\n");
            EndContext();
#line 9 "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
            BeginContext(121, 34, false);
#line 11 "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(161, 36, false);
#line 12 "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(199, 79, true);
            WriteLiteral("    <input type=\"submit\" value=\"Add product to cart\" class=\"btn btn-primary\"/>\n");
            EndContext();
#line 15 "/Users/Guest/Desktop/eCommerce.Solution/Ecommerce/Views/Products/Create.cshtml"
}

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
