#pragma checksum "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e3104575423c47ebd8b008067e109bf1a5126da"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/_ViewImports.cshtml"
using Mission13;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/_ViewImports.cshtml"
using Mission13.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e3104575423c47ebd8b008067e109bf1a5126da", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"43d66170eda39448e8bbeaab99a630e8ccdb701b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Bowler>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>List of Bowlers</h1>\n<br />\n<h2>");
#nullable restore
#line 8 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
Write(ViewBag.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n<ul>\n");
#nullable restore
#line 11 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
     foreach (var b in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li><i>Name:</i> ");
#nullable restore
#line 13 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                    Write(b.BowlerLastName);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 13 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                                       Write(b.BowlerFirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 13 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                                                            Write(b.BowlerMiddleInit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li><i>Address:</i> ");
#nullable restore
#line 14 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                       Write(b.BowlerAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 14 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                                        Write(b.BowlerCity);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 14 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                                                       Write(b.BowlerState);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 14 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                                                                        Write(b.BowlerZip);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n        <li><i>Phone Number:</i> (");
#nullable restore
#line 15 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
                             Write(b.BowlerPhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral(")</li>\n        <br />\n");
#nullable restore
#line 17 "/Users/hannahsouthwick/Documents/GitHub/Mission13/Mission13/Mission13/Views/Home/Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Bowler>> Html { get; private set; }
    }
}
#pragma warning restore 1591
