#pragma checksum "C:\Users\ADMIN\Documents\Francis\Job\26 ABSA\Solution\CallPhonebookAPIfromJqueryApp\CallPhonebookAPIfromJquery\CallPhonebookAPIfromJquery\Views\Home\CreateNewEntry.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e64c79e20cf62e8e2eed624c205d4e3d20e88629"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_CreateNewEntry), @"mvc.1.0.view", @"/Views/Home/CreateNewEntry.cshtml")]
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
#line 1 "C:\Users\ADMIN\Documents\Francis\Job\26 ABSA\Solution\CallPhonebookAPIfromJqueryApp\CallPhonebookAPIfromJquery\CallPhonebookAPIfromJquery\Views\_ViewImports.cshtml"
using CallPhonebookAPIfromJquery;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ADMIN\Documents\Francis\Job\26 ABSA\Solution\CallPhonebookAPIfromJqueryApp\CallPhonebookAPIfromJquery\CallPhonebookAPIfromJquery\Views\_ViewImports.cshtml"
using CallPhonebookAPIfromJquery.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e64c79e20cf62e8e2eed624c205d4e3d20e88629", @"/Views/Home/CreateNewEntry.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae7cfbc5992b64d1a5497d6be759f67df254557", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_CreateNewEntry : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/script/Phonebook.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\ADMIN\Documents\Francis\Job\26 ABSA\Solution\CallPhonebookAPIfromJqueryApp\CallPhonebookAPIfromJquery\CallPhonebookAPIfromJquery\Views\Home\CreateNewEntry.cshtml"
  
    ViewData["Title"] = "Create New Entry";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Create New Entry info</h1>\r\n\r\n\r\n<br />\r\n<br />\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64c79e20cf62e8e2eed624c205d4e3d20e886294458", async() => {
                WriteLiteral(@"
    <div class=""form-group"">
        <label for=""labeltextInputName"">Name</label>
        <input type=""text"" class=""form-control col-md-3"" id=""txtName"" />
    </div>
    <div class=""form-group"">
        <label for=""labeltextInputPhoneNumber"">Phone number</label>
        <input type=""text"" maxlength=""10"" pattern=""\d{10}"" title=""Please enter exactly 10 digits"" class=""form-control col-md-3"" id=""txtPhoneNumber"" />
    </div>

    <div class=""form-group"">
        <label for=""labeltextInputPhonebookId"">Select a Phonebook Name</label>
        <select id=""select-phonebook-name-list"" class=""form-control form-select form-select-lg col-md-3"" aria-label="".form-select-lg example"">
        </select>
    </div>

    <br />
    <button id=""btnAddNew"" class=""btn btn-primary"">Save</button>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n<script src=\"https://code.jquery.com/jquery-3.5.1.js\"></script>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e64c79e20cf62e8e2eed624c205d4e3d20e886296605", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<script type=""text/javascript"">
    $(document).ready(function () {

        sendData();

        function sendData() {

            $(""#btnAddNew"").click(function () {

                var dataName = $('#txtName').val();
                var dataPhoneNumber = $('#txtPhoneNumber').val();
                var dataPhonebookId = $('#select-phonebook-name-list').find("":selected"").val();
                var dataPhonebookIdParsed = parseInt(dataPhonebookId);

                const data = { name: dataName, phoneNumber: dataPhoneNumber, phonebookId: dataPhonebookIdParsed };

                fetch(""https://localhost:44389/api/entries"", {
                    method: 'post',
                    headers: {
                        'Accept': 'application/json, text/plain, */*',
                        'Content-Type': 'application/json'
                    },
                    body: JSON.stringify(data),
                }).then(res => res.json())
                    .then(data => {
             ");
            WriteLiteral("           console.log(\'Success\', data);\r\n                    })\r\n                    .catch((error) => {\r\n                        console.error(\'Error\', error.message);\r\n\r\n                    });\r\n            });\r\n        }\r\n    });\r\n\r\n</script>");
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
