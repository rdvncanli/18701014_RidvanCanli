#pragma checksum "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b78da4f4dc186a5d20c6fb05e3ba4c8979f4860b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp;

#line default
#line hidden
#line 2 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp.Models;

#line default
#line hidden
#line 3 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78da4f4dc186a5d20c6fb05e3ba4c8979f4860b", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb19df36a865842bd55640e009cf94376951932", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mekan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("500"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("275"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
            BeginContext(73, 187, true);
            WriteLiteral("<style>\r\n    .card-title {\r\n        overflow: hidden;\r\n        white-space: nowrap;\r\n        text-overflow: ellipsis;\r\n    }\r\n</style>\r\n<div class=\"row  d-flex justify-content-between\">\r\n");
            EndContext();
#line 13 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
            BeginContext(305, 79, true);
            WriteLiteral("      <div class=\"card \" style=\"width: 18rem; margin-bottom:30px;\">\r\n          ");
            EndContext();
            BeginContext(384, 107, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "76e0df66d2d542e0b25d0e0689edcebd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 415, "~/img/mekan/", 415, 12, true);
#line 16 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 427, item.mekanResim, 427, 16, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(491, 77, true);
            WriteLiteral("\r\n          <div class=\"card-body\">\r\n              <h4  class=\"card-title\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 568, "\"", 606, 4);
            WriteAttributeValue("", 575, "/", 575, 1, true);
#line 18 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 576, item.user, 576, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 586, "/mekan/", 586, 7, true);
#line 18 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 593, item.mekanId, 593, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(607, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(609, 13, false);
#line 18 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
                                                                           Write(item.mekanAdi);

#line default
#line hidden
            EndContext();
            BeginContext(622, 85, true);
            WriteLiteral("</a></h4>\r\n              <h5><span class=\"badge badge-warning\" style=\"color:darkred\">");
            EndContext();
            BeginContext(708, 12, false);
#line 19 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
                                                                     Write(item.CatName);

#line default
#line hidden
            EndContext();
            BeginContext(720, 30, true);
            WriteLiteral("</span></h5>\r\n              <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 750, "\"", 788, 4);
            WriteAttributeValue("", 757, "/", 757, 1, true);
#line 20 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 758, item.user, 758, 10, false);

#line default
#line hidden
            WriteAttributeValue("", 768, "/mekan/", 768, 7, true);
#line 20 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
WriteAttributeValue("", 775, item.mekanId, 775, 13, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(789, 74, true);
            WriteLiteral(" class=\"btn btn-primary\">Detayl?? G??r</a>\r\n          </div>\r\n      </div>\r\n");
            EndContext();
#line 23 "D:\Visual Studio Projects\myScoreApp\myScoreApp\Views\Home\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(872, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Mekan>> Html { get; private set; }
    }
}
#pragma warning restore 1591
