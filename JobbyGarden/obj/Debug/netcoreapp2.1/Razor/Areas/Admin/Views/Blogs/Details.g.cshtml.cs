#pragma checksum "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d6454fcb368a4bf126162cb90f545fe4d4f6b1f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Blogs_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Blogs/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Areas/Admin/Views/Blogs/Details.cshtml", typeof(AspNetCore.Areas_Admin_Views_Blogs_Details))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6454fcb368a4bf126162cb90f545fe4d4f6b1f", @"/Areas/Admin/Views/Blogs/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b853c2693020103458b52d8246f923ca3fd89014", @"/Areas/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Blogs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JobbyGarden.Models.Blog>
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
            BeginContext(32, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layoutpanel.cshtml";

#line default
#line hidden
            BeginContext(141, 254, true);
            WriteLiteral("<section class=\"content\" style=\"height:auto\">\r\n    <div class=\"container-fluid\">\r\n        <h2>Details</h2>\r\n\r\n        <div>\r\n            <h4>Blog</h4>\r\n            <hr />\r\n            <dl class=\"dl-horizontal\">\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(396, 40, false);
#line 16 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(436, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(504, 36, false);
#line 19 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
            EndContext();
            BeginContext(540, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(608, 45, false);
#line 22 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Blogdesc1));

#line default
#line hidden
            EndContext();
            BeginContext(653, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(721, 41, false);
#line 25 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.Blogdesc1));

#line default
#line hidden
            EndContext();
            BeginContext(762, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(830, 45, false);
#line 28 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Blogdesc2));

#line default
#line hidden
            EndContext();
            BeginContext(875, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(943, 41, false);
#line 31 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.Blogdesc2));

#line default
#line hidden
            EndContext();
            BeginContext(984, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1052, 41, false);
#line 34 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1093, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1161, 37, false);
#line 37 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
            EndContext();
            BeginContext(1198, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1266, 40, false);
#line 40 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1306, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1374, 36, false);
#line 43 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1410, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1478, 42, false);
#line 46 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1520, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1588, 38, false);
#line 49 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
            EndContext();
            BeginContext(1626, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1694, 48, false);
#line 52 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.blogCategory));

#line default
#line hidden
            EndContext();
            BeginContext(1742, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(1810, 49, false);
#line 55 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.blogCategory.Name));

#line default
#line hidden
            EndContext();
            BeginContext(1859, 67, true);
            WriteLiteral("\r\n                </dd>\r\n                <dt>\r\n                    ");
            EndContext();
            BeginContext(1927, 40, false);
#line 58 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.User));

#line default
#line hidden
            EndContext();
            BeginContext(1967, 67, true);
            WriteLiteral("\r\n                </dt>\r\n                <dd>\r\n                    ");
            EndContext();
            BeginContext(2035, 39, false);
#line 61 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
               Write(Html.DisplayFor(model => model.User.Id));

#line default
#line hidden
            EndContext();
            BeginContext(2074, 87, true);
            WriteLiteral("\r\n                </dd>\r\n            </dl>\r\n        </div>\r\n        <div>\r\n            ");
            EndContext();
            BeginContext(2161, 54, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fbb397a0869d48f8910160e371dab42d", async() => {
                BeginContext(2207, 4, true);
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
#line 66 "C:\Users\code\source\repos\JobbyGarden\JobbyGarden\Areas\Admin\Views\Blogs\Details.cshtml"
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
            BeginContext(2215, 16, true);
            WriteLiteral(" |\r\n            ");
            EndContext();
            BeginContext(2231, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3e71890ca3db4cbea4b62a0d0c9578cd", async() => {
                BeginContext(2253, 12, true);
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
            BeginContext(2269, 44, true);
            WriteLiteral("\r\n        </div>\r\n        </div>\r\n</section>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JobbyGarden.Models.Blog> Html { get; private set; }
    }
}
#pragma warning restore 1591
