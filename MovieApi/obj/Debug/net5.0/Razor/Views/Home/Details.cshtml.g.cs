#pragma checksum "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0bdb2437d7d30e756974fdbc4b91353f218a907d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
#line 1 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\_ViewImports.cshtml"
using MovieApi;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\_ViewImports.cshtml"
using MovieApi.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\_ViewImports.cshtml"
using MovieApi.HtmlHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0bdb2437d7d30e756974fdbc4b91353f218a907d", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e6b0997fe364d13359ede1978d3da0b7e8911c73", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Details>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_MovieCardPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n<div class=\"row\">\r\n    <div class=\"col-md-4\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "0bdb2437d7d30e756974fdbc4b91353f218a907d4092", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 10 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</partial>\r\n    </div>\r\n    <div class=\"col-md-8\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 15 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 18 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 21 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 24 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Year));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 27 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Rated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 30 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Rated));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 33 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Released));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 36 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Released));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 39 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 42 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Runtime));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 45 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 48 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 51 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 54 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Director));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 57 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Writer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 60 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Writer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 63 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 66 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 69 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 72 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Plot));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 75 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 78 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 81 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 84 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 87 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Awards));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 90 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Awards));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 93 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Metascore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 96 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Metascore));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 99 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.imdbRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 102 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.imdbRating));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 105 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.imdbVotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 108 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.imdbVotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 111 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.imdbID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 114 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.imdbID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 117 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 120 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 123 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.DVD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 126 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.DVD));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 129 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BoxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 132 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.BoxOffice));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 135 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Production));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 138 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Production));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 141 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Website));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 144 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Website));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 147 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Response));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 150 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Response));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 153 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Error));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 156 "D:\Сохранено\Downloads\Учеба\C#\Проекты C#\ASP.NET\ClassWork\MovieApi 2 Git\MovieApi-2\MovieApi\Views\Home\Details.cshtml"
           Write(Html.DisplayFor(model => model.Error));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Details> Html { get; private set; }
    }
}
#pragma warning restore 1591
