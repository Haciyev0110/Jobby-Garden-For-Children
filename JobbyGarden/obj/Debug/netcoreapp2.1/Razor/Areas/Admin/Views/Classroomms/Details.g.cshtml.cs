#pragma checksum "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5e927eb8f8088e4b15535469500766f3637604cd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Classroomms_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Classroomms/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Classroomms/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Classroomms_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5e927eb8f8088e4b15535469500766f3637604cd", @"/Areas/Admin/Views/Classroomms/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Classroomms_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobbyGarden.Models.Classroomm>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layoutpanel.cshtml";

#line default
#line hidden
            BeginContext(147, 262, true);
            WriteLiteral(@" <<section class=""content"" style=""height:auto"">
    <div class=""container-fluid"">
        <h2>Details</h2>

        <div>
            <h4>Classroomm</h4>
            <hr />
            <dl class=""dl-horizontal"">
                <dt>
                    ");
            EndContext();
            BeginContext(410, 40, false);
#line 16 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(450, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(518, 36, false);
#line 19 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(554, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(622, 45, false);
#line 22 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Iamgename));

#line default
#line hidden
            EndContext();
            BeginContext(667, 65, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                  ");
            EndContext();
            BeginContext(732, 47, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "3642516479fb4959b0ba14f3ccd275c9", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 742, "~/Librarry/Class/", 742, 17, true);
#line 25 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
AddHtmlAttributeValue("", 759, Model.Iamgename, 759, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(779, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(847, 41, false);
#line 28 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(888, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(956, 37, false);
#line 31 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(993, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1061, 47, false);
#line 34 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1108, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1176, 43, false);
#line 37 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1219, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1287, 40, false);
#line 40 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1327, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1395, 36, false);
#line 43 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Size));

#line default
#line hidden
            EndContext();
            BeginContext(1431, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1499, 46, false);
#line 46 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Openhourse));

#line default
#line hidden
            EndContext();
            BeginContext(1545, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1613, 42, false);
#line 49 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Openhourse));

#line default
#line hidden
            EndContext();
            BeginContext(1655, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1723, 46, false);
#line 52 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Closehours));

#line default
#line hidden
            EndContext();
            BeginContext(1769, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1837, 42, false);
#line 55 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Closehours));

#line default
#line hidden
            EndContext();
            BeginContext(1879, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1947, 44, false);
#line 58 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Startime));

#line default
#line hidden
            EndContext();
            BeginContext(1991, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2059, 40, false);
#line 61 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Startime));

#line default
#line hidden
            EndContext();
            BeginContext(2099, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2167, 43, false);
#line 64 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Teacher));

#line default
#line hidden
            EndContext();
            BeginContext(2210, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2278, 45, false);
#line 67 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Teacher.Email));

#line default
#line hidden
            EndContext();
            BeginContext(2323, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2391, 40, false);
#line 70 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Agee));

#line default
#line hidden
            EndContext();
            BeginContext(2431, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2499, 39, false);
#line 73 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Agee.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2538, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(2606, 44, false);
#line 76 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(2650, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2718, 45, false);
#line 79 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
               Write(Html.DisplayFor(model => model.Category.Name));

#line default
#line hidden
            EndContext();
            BeginContext(2763, 87, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(2850, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53fbb36a55a34ea2bc66350776f88202", async() => {
                BeginContext(2896, 4, true);
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
#line 84 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Classroomms\Details.cshtml"
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
            BeginContext(2904, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(2920, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "106eec4d631640619f32ec6399fe0838", async() => {
                BeginContext(2942, 12, true);
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
            BeginContext(2958, 36, true);
            WriteLiteral("\r\n        </div>\r\n</div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobbyGarden.Models.Classroomm> Html { get; private set; }
    }
}
#pragma warning restore 1591
