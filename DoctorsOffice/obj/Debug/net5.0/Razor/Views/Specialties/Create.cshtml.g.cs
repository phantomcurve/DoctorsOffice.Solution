#pragma checksum "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eead765d0a126fb7e181a70324f769debacd9502"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Specialties_Create), @"mvc.1.0.view", @"/Views/Specialties/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eead765d0a126fb7e181a70324f769debacd9502", @"/Views/Specialties/Create.cshtml")]
    public class Views_Specialties_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DoctorsOffice.Models.Specialty>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral("\n<h4>Add a new specialty</h4>\n\n");
#nullable restore
#line 9 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
 using (Html.BeginForm())
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
Write(Html.LabelFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
Write(Html.TextBoxFor(model => model.Name));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
Write(Html.Label("Select doctor"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
Write(Html.DropDownList("DoctorId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <input type=\"submit\" value=\"Add new specialty\" class=\"btn btn-default\" />\n");
#nullable restore
#line 18 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 19 "/Users/phantom/Desktop/DoctorsOffice.Solution/DoctorsOffice/Views/Specialties/Create.cshtml"
Write(Html.ActionLink("Show all specialties", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DoctorsOffice.Models.Specialty> Html { get; private set; }
    }
}
#pragma warning restore 1591