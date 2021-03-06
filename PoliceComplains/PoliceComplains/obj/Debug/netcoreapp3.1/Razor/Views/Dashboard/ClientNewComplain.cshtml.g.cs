#pragma checksum "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ClientNewComplain.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60b6ff99d5356a9ad06cf6d50209dbbd2571d511"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_ClientNewComplain), @"mvc.1.0.view", @"/Views/Dashboard/ClientNewComplain.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60b6ff99d5356a9ad06cf6d50209dbbd2571d511", @"/Views/Dashboard/ClientNewComplain.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9888d88bae41bfc1e7a1d41dcceed4adfd773e6", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_ClientNewComplain : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ClientNewComplain.cshtml"
  
    ViewData["Title"] = "ClientNewComplain";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div>
    <div class=""form-group"">
        <label>Title</label>
        <input type=""text"" class=""form-control"" id=""compalin_title"" placeholder=""Title of the complain"">
    </div>
    <div class=""form-group"">
        <label>Description</label>
        <textarea class=""form-control"" id=""compalin_description"" placeholder=""Description of the complain""></textarea>
    </div>
    <div class=""form-group"">
        <label>Claim documents</label>
        <input type=""file"" id=""file""/>

    </div>
    <ul id=""docs"" class=""form-group"">

    </ul>

    <button onclick=""save()""  class=""btn btn-primary"">Submit</button>
</div>

<script>

    var fileNames = [];
    $(""#file"").on(""change"",
        function() {
            var formData = new FormData();
            var file = $('input[type=file]')[0].files[0];
            formData.append(""ufile"", file);
            $.ajax({
                type: ""POST"",
                enctype: 'multipart/form-data',
                url: '");
#nullable restore
#line 37 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ClientNewComplain.cshtml"
                 Write(Url.Action("AddComplainDoc"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                data: formData,
                processData: false,
                contentType: false,
                cache: false,
                timeout: 600000,
                success: function(data) {
                    fileNames.push({ name: file.name, saved: data.fileName });
                    showFiles();
                }
            });

        });

    function remove(name) {
        name = name.trim();
        var index = fileNames.findIndex(x => x.name === name);
        if (index > -1) {
            fileNames.splice(index, 1);
        }
        showFiles();
    }

    showFiles();

    function showFiles() {
        $(""#docs"").empty();
        fileNames.forEach(f => {
            $(""#docs"").append('<li>' +
                f.name +
                ' - <button class=""btn btn-danger"" onclick=""remove(\'' +
                f.name +
                '\')""  >Remove</button></li>');
        });

    }

    function save() {
        var formData = new FormDa");
            WriteLiteral(@"ta();
        formData.append(""Title"", $(""#compalin_title"").val());
        formData.append(""Description"", $(""#compalin_description"").val());
        formData.append(""Title"", $(""#compalin_title"").val());
       
        formData.append(""Status"", fileNames.map(e=>(e.saved+'*'+e.name)).join(','));
        $.ajax({
            type: ""POST"",
            enctype: 'multipart/form-data',
            url: '");
#nullable restore
#line 84 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ClientNewComplain.cshtml"
             Write(Url.Action("ClientNewComplain"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            data: formData,
            processData: false,
            contentType: false,
            cache: false,
            timeout: 600000,
            success: function(data) {
                if (data.status) {
                    window.location.href = '");
#nullable restore
#line 92 "C:\Users\Eranga\Documents\Projects\PoliceComlain\PoliceComplains\PoliceComplains\Views\Dashboard\ClientNewComplain.cshtml"
                                       Write(Url.Action("Client"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\';\r\n                } else {\r\n                    alert(\'error\');\r\n                }\r\n            }\r\n        });\r\n    }\r\n</script>");
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
