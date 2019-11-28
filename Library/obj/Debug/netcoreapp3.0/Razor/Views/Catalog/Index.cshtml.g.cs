#pragma checksum "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91375b29b5865e6739a1278cbf6425908b00d4dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Index), @"mvc.1.0.view", @"/Views/Catalog/Index.cshtml")]
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
#line 1 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\_ViewImports.cshtml"
using Library.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91375b29b5865e6739a1278cbf6425908b00d4dc", @"/Views/Catalog/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dadb7a731bfbb305c411bc5eb7a307dbd6008a89", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Catalog.AssetIndexModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Catalog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
   
    ViewBag.Title = "Library Catalog";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div id=\"assets\">\r\n   <h1>");
#nullable restore
#line 8 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
  Write(ViewBag.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>

   <div id=""assetsTable"">
       <table class=""table table-condensed"" id=""catalogIndexTable"">
           <thead>
               <tr>
                   <th>Image</th>
                   <th>Title</th>
                   <th>Author/Director</th>
                   <th>Dewey Call Number</th>
               </tr>
           </thead>
           <tbody>
");
#nullable restore
#line 21 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
                foreach(var asset in Model.Assets)
               {

#line default
#line hidden
#nullable disable
            WriteLiteral("                   <tr class=\"assetRow\">\r\n                       <td");
            BeginWriteAttribute("class", " class=\"", 648, "\"", 656, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                           ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "91375b29b5865e6739a1278cbf6425908b00d4dc5075", async() => {
                WriteLiteral("<img");
                BeginWriteAttribute("src", " src=\"", 764, "\"", 785, 1);
#nullable restore
#line 25 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
WriteAttributeValue("", 770, asset.ImageUrl, 770, 15, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 25 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
                                                                             WriteLiteral(asset.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral("                           \r\n                       </td>\r\n                       <td");
            BeginWriteAttribute("class", " class=\"", 878, "\"", 886, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 27 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
                               Write(asset.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td");
            BeginWriteAttribute("class", " class=\"", 933, "\"", 941, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 28 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
                               Write(asset.AuthorOrDirector);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                       <td");
            BeginWriteAttribute("class", " class=\"", 999, "\"", 1007, 0);
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 29 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
                               Write(asset.DeweyCallNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                   </tr>\r\n");
#nullable restore
#line 31 "C:\Users\Majid.Alikhani\source\repos\Library\Library\Views\Catalog\Index.cshtml"
               }

#line default
#line hidden
#nullable disable
            WriteLiteral("           </tbody>\r\n       </table>\r\n   </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Catalog.AssetIndexModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
