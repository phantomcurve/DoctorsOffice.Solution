#pragma checksum "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35bc2fdca72a8e94d9321486b1435bbe40058e1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patients_AddDoctor), @"mvc.1.0.view", @"/Views/Patients/AddDoctor.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35bc2fdca72a8e94d9321486b1435bbe40058e1f", @"/Views/Patients/AddDoctor.cshtml")]
    public class Views_Patients_AddDoctor : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Patient>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h2>Add a doctor</h2>\n\n<h4>Add a doctor for this patient: ");
#nullable restore
#line 9 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
                              Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\n\n");
#nullable restore
#line 11 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
Write(Html.HiddenFor(model => model.PatientId));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
Write(Html.Label("Select doctor"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
Write(Html.DropDownList("DoctorId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Save\" />\n");
#nullable restore
#line 19 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<p>");
#nullable restore
#line 21 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Patients/AddDoctor.cshtml"
Write(Html.ActionLink("Back to list", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Patient> Html { get; private set; }
    }
}
#pragma warning restore 1591
