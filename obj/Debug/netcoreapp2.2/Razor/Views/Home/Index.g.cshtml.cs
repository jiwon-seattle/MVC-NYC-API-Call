#pragma checksum "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9950543d3413743084d0239e9f686cba924f88f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "/Users/Guest/Desktop/MvcApiCall/Views/_ViewImports.cshtml"
using MvcApiCall;

#line default
#line hidden
#line 2 "/Users/Guest/Desktop/MvcApiCall/Views/_ViewImports.cshtml"
using MvcApiCall.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9950543d3413743084d0239e9f686cba924f88f7", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f23a777e9ef0fdfd0407564fbf2dfc5793fb9fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(45, 85, true);
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">All Articles:</h1>\r\n    <ol>\r\n");
            EndContext();
#line 8 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
     foreach(Article article in Model)
    {

#line default
#line hidden
            BeginContext(177, 39, true);
            WriteLiteral("        <ul>\r\n            <li>Section: ");
            EndContext();
            BeginContext(217, 15, false);
#line 11 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
                    Write(article.Section);

#line default
#line hidden
            EndContext();
            BeginContext(232, 30, true);
            WriteLiteral("</li>\r\n            <li>Title: ");
            EndContext();
            BeginContext(263, 13, false);
#line 12 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
                  Write(article.Title);

#line default
#line hidden
            EndContext();
            BeginContext(276, 33, true);
            WriteLiteral("</li>\r\n            <li>Abstract: ");
            EndContext();
            BeginContext(310, 16, false);
#line 13 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
                     Write(article.Abstract);

#line default
#line hidden
            EndContext();
            BeginContext(326, 28, true);
            WriteLiteral("</li>\r\n            <li>Url: ");
            EndContext();
            BeginContext(355, 11, false);
#line 14 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
                Write(article.Url);

#line default
#line hidden
            EndContext();
            BeginContext(366, 31, true);
            WriteLiteral("</li>\r\n            <li>Byline: ");
            EndContext();
            BeginContext(398, 14, false);
#line 15 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
                   Write(article.Byline);

#line default
#line hidden
            EndContext();
            BeginContext(412, 36, true);
            WriteLiteral("</li>\r\n        </ul>\r\n        <br>\r\n");
            EndContext();
#line 18 "/Users/Guest/Desktop/MvcApiCall/Views/Home/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(455, 19, true);
            WriteLiteral("    </ol>\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
