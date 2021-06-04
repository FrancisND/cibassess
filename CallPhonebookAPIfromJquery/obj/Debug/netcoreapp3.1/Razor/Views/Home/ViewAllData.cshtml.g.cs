#pragma checksum "C:\Users\ADMIN\Documents\Francis\Job\26 ABSA\Solution\CallPhonebookAPIfromJqueryApp\CallPhonebookAPIfromJquery\CallPhonebookAPIfromJquery\Views\Home\ViewAllData.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "201343276487ba5e09c17478dcd9bba57f7fc2f4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_ViewAllData), @"mvc.1.0.view", @"/Views/Home/ViewAllData.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"201343276487ba5e09c17478dcd9bba57f7fc2f4", @"/Views/Home/ViewAllData.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dae7cfbc5992b64d1a5497d6be759f67df254557", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_ViewAllData : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<br />\r\n<br />\r\n<br />\r\n<h1>View Phone Book</h1>\r\n<br />\r\n<br />\r\n<br />\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "201343276487ba5e09c17478dcd9bba57f7fc2f43475", async() => {
                WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.5.1.js""></script>
    <script type=""text/javascript"" src=""https://cdn.datatables.net/1.10.24/js/jquery.dataTables.min.js""></script>
    <link href=""https://cdn.datatables.net/1.10.24/css/jquery.dataTables.min.css"" rel=""stylesheet"">
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

<!-- Begin Page Content -->
<div class=""container-fluid"">


    <table id=""table_id"" class=""display"">
        <thead>
            <tr>
                <th>Entry Name</th>
                <th>Phone number</th>
            </tr>
        </thead>
        <tbody>
        </tbody>
    </table>

</div>


<script type=""text/javascript"">
    $(document).ready(function () {

        $('#table_id').DataTable();

        var phonebkGlobal;


        // ******** 1. Phonebook Start

        const controller = new AbortController();

        getData();

        async function getData() {
            const response = await fetch('https://localhost:44389/api/phonebooks');
            const settings = {
                method: 'get',
                headers: {
                    'Accept': 'application/json, text/plain, */*',
                    'Content-Type': 'application/json'
                }
            };
            const phonebk = await response.json();

            var ");
            WriteLiteral(@"arrayToString = JSON.stringify(Object.assign({}, phonebk));  // convert array to string
            var stringToJsonObject = JSON.parse(arrayToString);  // convert string to json object

            return stringToJsonObject;
        }

        getData().then(phonebk => {
            phonebk;

            phonebkGlobal = phonebk;

            var trHTML = '';
            $.each(phonebk, function (index, value) {
                console.log(value.name);
                trHTML += '<tr><td>' + value.name + '</td></tr>';
            });
            $('#table_id').append(trHTML);

        });

        // ******** 1. Phonebook End





        // ******** 2. Entry Start

        //getDataEntry();

        //async function getDataEntry() {
        //    const response = await fetch('https://localhost:44389/api/entries');
        //    const settings = {
        //        method: 'get',
        //        headers: {
        //            'Accept': 'application/json, text/plain, */*',");
            WriteLiteral(@"
        //            'Content-Type': 'application/json'
        //        }
        //    };
        //    const entrybk = await response.json();

        //    var arrayToString = JSON.stringify(Object.assign({}, entrybk));     // convert array to string
        //    var stringToJsonObject = JSON.parse(arrayToString);                 // convert string to json object

        //    return stringToJsonObject;

        //}

        //getDataEntry().then(entrybk => {
        //    entrybk;

        //    var trHTML = '';
        //    $.each(entrybk, function (index, value) {
        //        //console.log(value.name);
        //        //console.log(value.phoneNumber);
        //        //trHTML += '<tr><td>' +  '</td></tr>' + value.name + '</td></tr>' + value.phoneNumber + '</td></tr>';

        //        trHTML += '<tr><td>' + value.name + '</td></tr>' + value.phoneNumber + '</td></tr>';


        //    });
        //    $('#table_id').append(trHTML);


        //    //$('#tab");
            WriteLiteral(@"le_id tr:last').eq(0).append(trHTML);


        //});

        // ******** 2. Entry End


        // Mix both data to be displayed in table



        //$('#table_id').DataTable({
        //    ""ajax"": phonebkGlobal


        //});


    });
</script>");
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
