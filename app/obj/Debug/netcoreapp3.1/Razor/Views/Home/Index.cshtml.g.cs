#pragma checksum "/app/Views/Home/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f8fca6b563dd88aca14c16f2731d6ce6b9f1c3"
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
#line 1 "/app/Views/_ViewImports.cshtml"
using Destiny2StatsApiDotNet;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/app/Views/_ViewImports.cshtml"
using Destiny2StatsApiDotNet.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f8fca6b563dd88aca14c16f2731d6ce6b9f1c3", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d671fe62871c67ecf2d60fcba35e8a92f475b82", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/app/Views/Home/Index.cshtml"
  
    ViewData["Title"] = "Stats";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h1>Stats</h1>\n\n<h2>");
#nullable restore
#line 7 "/app/Views/Home/Index.cshtml"
Write(Model.Username);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>");
#nullable restore
#line 8 "/app/Views/Home/Index.cshtml"
Write(Model.KillDeath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>");
#nullable restore
#line 9 "/app/Views/Home/Index.cshtml"
Write(Model.creationDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>");
#nullable restore
#line 10 "/app/Views/Home/Index.cshtml"
Write(Model.favoriteWeapon);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>");
#nullable restore
#line 11 "/app/Views/Home/Index.cshtml"
Write(Model.hoursPlayed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n<h2>");
#nullable restore
#line 12 "/app/Views/Home/Index.cshtml"
Write(Model.powerLevel);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\n\n");
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
