#pragma checksum "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aad24677b79d60311b8be10a3704d8c648976e11"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctors_Create), @"mvc.1.0.view", @"/Views/Doctors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aad24677b79d60311b8be10a3704d8c648976e11", @"/Views/Doctors/Create.cshtml")]
    public class Views_Doctors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Doctor>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>Add a new doctor</h4>\n");
#nullable restore
#line 8 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.LabelFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.TextBoxFor(model => model.Specialty));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new doctor\" />\n");
#nullable restore
#line 15 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 16 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Doctors/Create.cshtml"
Write(Html.ActionLink("Show all doctors", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Doctor> Html { get; private set; }
    }
}
#pragma warning restore 1591