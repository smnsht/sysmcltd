#pragma checksum "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ab46be0e2f24165fe1bbf535901951ba18b671d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Details), @"mvc.1.0.view", @"/Views/Customers/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Customers/Details.cshtml", typeof(AspNetCore.Views_Customers_Details))]
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
#line 1 "/home/simon/Dev/workspace/core/sysmcltd/Views/_ViewImports.cshtml"
using sysmcltd;

#line default
#line hidden
#line 2 "/home/simon/Dev/workspace/core/sysmcltd/Views/_ViewImports.cshtml"
using sysmcltd.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab46be0e2f24165fe1bbf535901951ba18b671d1", @"/Views/Customers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fa70733d5408160fd1a231a9abc5cc7cb4c23fe0", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<sysmcltd.Models.Customer>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(33, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(78, 146, true);
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">                        \r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(225, 40, false);
#line 14 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(265, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(309, 36, false);
#line 17 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(345, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(389, 50, false);
#line 20 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.CustomerNumber));

#line default
#line hidden
            EndContext();
            BeginContext(439, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(483, 46, false);
#line 23 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
       Write(Html.DisplayFor(model => model.CustomerNumber));

#line default
#line hidden
            EndContext();
            BeginContext(529, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(573, 43, false);
#line 26 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(616, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(660, 39, false);
#line 29 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
       Write(Html.DisplayFor(model => model.Created));

#line default
#line hidden
            EndContext();
            BeginContext(699, 325, true);
            WriteLiteral(@"
        </dd>
    </dl>
    <br />
    <h4>Contacts:</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th>Full Name</th>
                <th>Office Number</th>
                <th>Email</th>
                <th>Created At</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 44 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
         foreach (var contact in Model.Contacts)
        {

#line default
#line hidden
            BeginContext(1085, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(1124, 16, false);
#line 47 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
               Write(contact.FullName);

#line default
#line hidden
            EndContext();
            BeginContext(1140, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1168, 20, false);
#line 48 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
               Write(contact.OfficeNumber);

#line default
#line hidden
            EndContext();
            BeginContext(1188, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1216, 13, false);
#line 49 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
               Write(contact.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1229, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(1257, 15, false);
#line 50 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
               Write(contact.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1272, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 52 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
        }

#line default
#line hidden
            BeginContext(1309, 286, true);
            WriteLiteral(@"        </tbody>
    </table>
    <br />
    <h4>Addresses:</h4>
    <table class=""table"">
        <thead>
            <tr>
                <th>City</th>
                <th>Street</th>
                <th>Created At</th>
            </tr>
        </thead>
        <tbody>
");
            EndContext();
#line 66 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
             foreach (var addr in Model.Addresses)
            {

#line default
#line hidden
            BeginContext(1662, 46, true);
            WriteLiteral("                <tr>\r\n                    <td>");
            EndContext();
            BeginContext(1709, 9, false);
#line 69 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
                   Write(addr.City);

#line default
#line hidden
            EndContext();
            BeginContext(1718, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1750, 11, false);
#line 70 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
                   Write(addr.Street);

#line default
#line hidden
            EndContext();
            BeginContext(1761, 31, true);
            WriteLiteral("</td>\r\n                    <td>");
            EndContext();
            BeginContext(1793, 12, false);
#line 71 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
                   Write(addr.Created);

#line default
#line hidden
            EndContext();
            BeginContext(1805, 30, true);
            WriteLiteral("</td>\r\n                </tr>\r\n");
            EndContext();
#line 73 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
            }

#line default
#line hidden
            BeginContext(1850, 51, true);
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n<div>\r\n    ");
            EndContext();
            BeginContext(1901, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9eaab670648344d68d7501f39f7431ac", async() => {
                BeginContext(1947, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 78 "/home/simon/Dev/workspace/core/sysmcltd/Views/Customers/Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1955, 8, true);
            WriteLiteral(" |\r\n    ");
            EndContext();
            BeginContext(1963, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3b763b51f8ed49d1ba3325df9c85e136", async() => {
                BeginContext(1985, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2001, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<sysmcltd.Models.Customer> Html { get; private set; }
    }
}
#pragma warning restore 1591