#pragma checksum "C:\Users\Dhiren\Downloads\dotnetMvcPrjct\CarRentHub_.net-core-master\WDDN_DotNetCore_Project_CE082_CE083_CE085\RentCarHub1\Views\ReturnCar\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4588df852d20742c280b2fb7bb26e26b4ff30487"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ReturnCar_Index), @"mvc.1.0.view", @"/Views/ReturnCar/Index.cshtml")]
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
#line 1 "C:\Users\Dhiren\Downloads\dotnetMvcPrjct\CarRentHub_.net-core-master\WDDN_DotNetCore_Project_CE082_CE083_CE085\RentCarHub1\Views\_ViewImports.cshtml"
using RentCarHub1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Dhiren\Downloads\dotnetMvcPrjct\CarRentHub_.net-core-master\WDDN_DotNetCore_Project_CE082_CE083_CE085\RentCarHub1\Views\_ViewImports.cshtml"
using RentCarHub1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4588df852d20742c280b2fb7bb26e26b4ff30487", @"/Views/ReturnCar/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f11aa7da7dbd612115fe921001b21329865fc6b", @"/Views/_ViewImports.cshtml")]
    public class Views_ReturnCar_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\n    <div class=\"col-sm-4\">\n\n");
#nullable restore
#line 4 "C:\Users\Dhiren\Downloads\dotnetMvcPrjct\CarRentHub_.net-core-master\WDDN_DotNetCore_Project_CE082_CE083_CE085\RentCarHub1\Views\ReturnCar\Index.cshtml"
         using (Html.BeginForm("Save", "ReturnCar", FormMethod.Post, new { id = "popupForm" }))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div>\n                <h1>Car Rentail</h1>\n            </div>\n");
            WriteLiteral("            <div class=\"form-group\">\n                <label class=\"form-label\">Car No</label>\n                <input type=\"text\" id=\"carno\" name=\"carno\" class=\"form-control\" placeholder=\"carid\" required />\n\n            </div>\n");
            WriteLiteral("            <div class=\"form-group\">\n                <label class=\"form-label\">Customer id</label>\n                <input type=\"text\" id=\"custid\" name=\"custid\" class=\"form-control\" placeholder=\"CustId\" required />\n            </div>\n");
            WriteLiteral("            <div class=\"form-group\">\n                <label class=\"form-label\">Date</label>\n                <input type=\"text\" id=\"date\" name=\"date\" class=\"form-control\" placeholder=\"date\" required />\n            </div>\n");
            WriteLiteral("            <div class=\"form-group\">\n                <label class=\"form-label\">Days Elapsed</label>\n                <input type=\"text\" id=\"elsp\" name=\"elsp\" class=\"form-control\" placeholder=\"Days Delayed\" required />\n            </div>\n");
            WriteLiteral("            <div class=\"form-group\">\n                <label class=\"form-label\">Fine</label>\n                <input type=\"text\" id=\"fine\" name=\"fine\" class=\"form-control\" placeholder=\"fine\" required />\n            </div>\n");
            WriteLiteral("            <div class=\"form-group\">\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-success\" />\n            </div>\n");
#nullable restore
#line 39 "C:\Users\Dhiren\Downloads\dotnetMvcPrjct\CarRentHub_.net-core-master\WDDN_DotNetCore_Project_CE082_CE083_CE085\RentCarHub1\Views\ReturnCar\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n\n</div>\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4588df852d20742c280b2fb7bb26e26b4ff304876885", async() => {
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
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4588df852d20742c280b2fb7bb26e26b4ff304877982", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4588df852d20742c280b2fb7bb26e26b4ff304879079", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"

    <script>
        getCarid();

        function daysdifference(firstDate, secondDate) {
            var startDay = new Date(firstDate);
            var endDay = new Date(secondDate);

            var millisBetween = startDay.getTime() - endDay.getTime();

            var days = millisBetween / (1000 * 3600 * 24);

            return Math.round(days);
        }


        function getCarid() {
            $(""#carno"").keyup(function (e) {
                $.ajax({
                    type: 'POST',
                    url: 'ReturnCar/Getid?carno=' + $(""#carno"").val(),
                    dataType: 'JSON',
                    success: function (data) {
                        console.log(data);
                        $('#custid').val(data[0].custid);
                        $('#date').val(data[0].enddate);

                        var days = daysdifference(new Date(), data[0].enddate);

                        console.log(days);
                        $('#elsp').val(days);

                        if (days >");
                WriteLiteral(@" 0) {
                            var fine = days * 100;
                            console.log(fine);
                            $('#fine').val(fine);
                        }
                        else {
                            $('#fine').val(""0"");
                        }
                    }

                });
            });
        }
    </script>
");
            }
            );
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