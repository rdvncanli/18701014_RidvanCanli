#pragma checksum "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\Shared\Components\Benzer\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f55e9b66f8d2bc722537a0da5825a309191a196d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Benzer_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Benzer/Default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Components/Benzer/Default.cshtml", typeof(AspNetCore.Views_Shared_Components_Benzer_Default))]
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
#line 1 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp;

#line default
#line hidden
#line 2 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp.Models;

#line default
#line hidden
#line 3 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\_ViewImports.cshtml"
using myScoreApp.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f55e9b66f8d2bc722537a0da5825a309191a196d", @"/Views/Shared/Components/Benzer/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cb19df36a865842bd55640e009cf94376951932", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_Benzer_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Mekan>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("height", new global::Microsoft.AspNetCore.Html.HtmlString("250"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\Shared\Components\Benzer\Default.cshtml"
 foreach (var item in Model.Where(x => x.CatName ==ViewBag.MekanCat && x.mekanId != ViewBag.MekanID).Take(4))
{

    

#line default
#line hidden
            BeginContext(149, 46, true);
            WriteLiteral("<div class=\"col-md-3 col-sm-6 mb-4\">\r\n    <h5>");
            EndContext();
            BeginContext(196, 16, false);
#line 7 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\Shared\Components\Benzer\Default.cshtml"
   Write(item.hastalikAdi);

#line default
#line hidden
            EndContext();
            BeginContext(212, 11, true);
            WriteLiteral("</h5>\r\n    ");
            EndContext();
            BeginContext(223, 156, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a951a3aa939b485786e96efabc0ca77f", async() => {
                BeginContext(266, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(276, 93, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8bad89dadcd04f19a0f9cf71889ad3e0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                AddHtmlAttributeValue("", 304, "~/img/mekan/", 304, 12, true);
#line 9 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\Shared\Components\Benzer\Default.cshtml"
AddHtmlAttributeValue("", 316, item.hastalikResmi, 316, 19, false);

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
                BeginContext(369, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "href", 4, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 232, "~/", 232, 2, true);
#line 8 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\Shared\Components\Benzer\Default.cshtml"
AddHtmlAttributeValue("", 234, item.user, 234, 10, false);

#line default
#line hidden
            AddHtmlAttributeValue("", 244, "/mekan/", 244, 7, true);
#line 8 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\Shared\Components\Benzer\Default.cshtml"
AddHtmlAttributeValue("", 251, item.mekanId, 251, 13, false);

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
            BeginContext(379, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
#line 12 "C:\Users\Rıdvan Canli\OneDrive\Masaüstü\18701014_RidvanCanli\myScoreApp\Views\Shared\Components\Benzer\Default.cshtml"
}

#line default
#line hidden
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
