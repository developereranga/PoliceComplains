#pragma checksum "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b9bee54e614c8c4e55540aea1c1a8c9b95d20769"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ViewComplain), @"mvc.1.0.view", @"/Views/Dashboard/ViewComplain.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
using PoliceComplains.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b9bee54e614c8c4e55540aea1c1a8c9b95d20769", @"/Views/Dashboard/ViewComplain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9888d88bae41bfc1e7a1d41dcceed4adfd773e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ViewComplain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-inline"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("margin-top: 10px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
  
    ViewData["Title"] = "ViewComplain";
    Complains c = ViewBag.complain;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<a class=\"btn btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 181, "\"", 261, 1);
#nullable restore
#line 10 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
WriteAttributeValue("", 188, Url.Action(User.Claims.First(x => x.Type.Equals(ClaimTypes.Role)).Value), 188, 73, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">< Back to claims</a>\r\n");
#nullable restore
#line 11 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
  
    var role = User.Claims.First(x => x.Type.Equals(ClaimTypes.Role)).Value;
    if (role.Equals("admin") && c.Status != "Case closed")
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 481, "\"", 531, 1);
#nullable restore
#line 15 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
WriteAttributeValue("", 488, Url.Action("CaseClose",new { caseId=c.Id}), 488, 43, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Case close</a>\r\n");
#nullable restore
#line 16 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<a class=\"btn btn-info\"");
            BeginWriteAttribute("href", " href=\"", 596, "\"", 647, 1);
#nullable restore
#line 18 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
WriteAttributeValue("", 603, Url.Action("PrintComplain",new { cid=c.Id}), 603, 44, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" role=\"button\">Print</a>\r\n<h1>");
#nullable restore
#line 19 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
Write(c.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n<div class=\"card\">\r\n    <div class=\"card-body\">\r\n        <p>");
#nullable restore
#line 22 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
      Write(c.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    </div>\r\n</div>\r\n<div class=\"row\">\r\n    <div class=\"col-sm \">\r\n        <h4>Messages</h4>\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div style=\"overflow-y: scroll; height:170px;\">\r\n");
#nullable restore
#line 31 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                      
                        if (c.ComplainFeedback != null)
                        {
                            foreach (var fb in c.ComplainFeedback)
                            {
                                if (fb.UserId.Equals(ViewBag.userId))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"float-right text-break msg\">");
#nullable restore
#line 38 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                                                                       Write(fb.Message.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n");
#nullable restore
#line 39 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <div class=\"float-left text-break msg\">");
#nullable restore
#line 42 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                                                                      Write(fb.Message.Trim());

#line default
#line hidden
#nullable disable
            WriteLiteral("</div><br />\r\n");
#nullable restore
#line 43 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                                }
                            }

                        }
                    

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 51 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
          
            if (!c.Status.Equals("Case closed"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b9bee54e614c8c4e55540aea1c1a8c9b95d2076910540", async() => {
                WriteLiteral("\r\n                    <div class=\"form-group mx-sm-3 mb-2\">\r\n\r\n                        <input type=\"text\" class=\"form-control\" name=\"Message\" placeholder=\"Enter your message here\">\r\n\r\n                    </div>\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2239, "\"", 2256, 1);
#nullable restore
#line 59 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
WriteAttributeValue("", 2247, c.UserId, 2247, 9, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"UserId\" />\r\n                    <input type=\"hidden\"");
                BeginWriteAttribute("value", " value=\"", 2316, "\"", 2329, 1);
#nullable restore
#line 60 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
WriteAttributeValue("", 2324, c.Id, 2324, 5, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"ComplainId\" />\r\n                    <button type=\"submit\" class=\"btn btn-primary mb-2\">Send</button>\r\n                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 53 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
AddHtmlAttributeValue("", 1920, Url.Action("SendMessage"), 1920, 26, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
#nullable restore
#line 62 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                       }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div class=\"col-sm\">\r\n        <h4>Attachments</h4>\r\n        <div class=\"card\">\r\n            <div class=\"card-body\">\r\n                <div style=\"overflow-y: scroll; height:170px;\">\r\n                    <ul>\r\n");
#nullable restore
#line 72 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                          
                            if (c.ComplainDocs != null)
                            {
                                foreach (var doc in c.ComplainDocs)
                                {
                                    var location = "/" + c.UserId + "/" + doc.FileName;

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <li>\r\n                                        <a target=\"_blank\"");
            BeginWriteAttribute("href", " href=\"", 3111, "\"", 3127, 1);
#nullable restore
#line 79 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
WriteAttributeValue("", 3118, location, 3118, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 79 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                                                                       Write(doc.RealName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                                    </li>\r\n");
#nullable restore
#line 81 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ViewComplain.cshtml"
                                }
                            }
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </ul>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n            </div>\r\n\r\n\r\n");
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
