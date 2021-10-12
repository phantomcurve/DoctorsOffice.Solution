#pragma checksum "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ad2048cdc36debf412eb01f3f545478296ff11d0"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Index), @"mvc.1.0.view", @"/Views/Specialties/Index.cshtml")]
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
#line 5 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
using DoctorsOffice.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ad2048cdc36debf412eb01f3f545478296ff11d0", @"/Views/Specialties/Index.cshtml")]
    public class Views_Specialties_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<DoctorsOffice.Models.Specialty>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h1>Specialty</h1>\n\n");
#nullable restore
#line 10 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
 if (@Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h3>No specialties have been added yet!</h3>\n");
#nullable restore
#line 13 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
} 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
#nullable restore
#line 15 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
 foreach (Specialty specialty in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <li>");
#nullable restore
#line 17 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
 Write(Html.ActionLink($"{specialty.Name}", "Details", new { id = specialty.SpecialtyId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\n");
#nullable restore
#line 18 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 20 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
Write(Html.ActionLink("Add new specialty", "Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n<p>");
#nullable restore
#line 21 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Index.cshtml"
Write(Html.ActionLink("Home", "Index", "Home"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<DoctorsOffice.Models.Specialty>> Html { get; private set; }
    }
}
#pragma warning restore 1591
