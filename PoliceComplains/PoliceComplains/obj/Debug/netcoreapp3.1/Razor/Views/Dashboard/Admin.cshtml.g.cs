#pragma checksum "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6f0683317e9bbd9b0e1cee22ddc6943f6a283bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Admin), @"mvc.1.0.view", @"/Views/Dashboard/Admin.cshtml")]
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
#line 1 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\_ViewImports.cshtml"
using PoliceComplains;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\_ViewImports.cshtml"
using PoliceComplains.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6f0683317e9bbd9b0e1cee22ddc6943f6a283bc", @"/Views/Dashboard/Admin.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9888d88bae41bfc1e7a1d41dcceed4adfd773e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Admin : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
  
    ViewData["Title"] = "Admin";

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n \r\n        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 85, "\"", 136, 1);
#nullable restore
#line 7 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
WriteAttributeValue("", 92, Url.Action("Admin",new { status="pending"}), 92, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Pending</a>\r\n        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 199, "\"", 254, 1);
#nullable restore
#line 8 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
WriteAttributeValue("", 206, Url.Action("Admin",new { status="in progress"}), 206, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">In Progress</a>\r\n        <a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 321, "\"", 376, 1);
#nullable restore
#line 9 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
WriteAttributeValue("", 328, Url.Action("Admin",new { status="case closed"}), 328, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Case Closed</a>\r\n<a class=\"btn btn-success\"");
            BeginWriteAttribute("href", " href=\"", 435, "\"", 462, 1);
#nullable restore
#line 10 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
WriteAttributeValue("", 442, Url.Action("Admin"), 442, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">All</a>\r\n<a class=\"btn btn-info\" style=\"margin-left: 50px\"");
            BeginWriteAttribute("href", " href=\"", 536, "\"", 565, 1);
#nullable restore
#line 11 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
WriteAttributeValue("", 543, Url.Action("EditDoc"), 543, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" role=""button"">Manage Docs</a>
  

<table class=""table"" style=""margin-top: 15px"">
    <thead class=""thead-dark"">
    <tr>
        <th scope=""col"">Title</th>
        <th scope=""col"">Status</th>
        <th scope=""col"">Action</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 23 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
      
        foreach (var c in ViewBag.complains)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 27 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
               Write(c.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
               Write(c.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 1039, "\"", 1088, 1);
#nullable restore
#line 29 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
WriteAttributeValue("", 1046, Url.Action("ViewComplain",new { id=c.Id}), 1046, 42, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">View</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\Admin.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
