#pragma checksum "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e8e8cb50c4f05729df9278843bad070c1a491ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Result), @"mvc.1.0.view", @"/Views/Home/Result.cshtml")]
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
#line 1 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1e8e8cb50c4f05729df9278843bad070c1a491ee", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c01cfe949fe35887b9c045e9ef2e2f5e2e69041", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ResultPageViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "checkbox", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Vegan"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Gluten Free"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Dairy Free"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Healthy"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Filter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
  
    ViewData["Title"] = "Search Result";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>Filter</p>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e8e8cb50c4f05729df9278843bad070c1a491ee7656", async() => {
                WriteLiteral("\r\n    <label>Vegan</label>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e8e8cb50c4f05729df9278843bad070c1a491ee7946", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
#nullable restore
#line 9 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isVegan);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            \r\n    <label>Gluten Free</label>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e8e8cb50c4f05729df9278843bad070c1a491ee9915", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
#nullable restore
#line 12 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isGlutenFree);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            \r\n    <label>Dairy Free</label>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e8e8cb50c4f05729df9278843bad070c1a491ee11889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
#nullable restore
#line 15 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isDairyFree);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n    <label>Healthy</label>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "1e8e8cb50c4f05729df9278843bad070c1a491ee13852", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
#nullable restore
#line 18 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.isHealthy);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    \r\n    <button type=\"submit\">Apply Filter</button>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div class=\"container\">\r\n");
#nullable restore
#line 24 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
     for (var i = 0; i < Model.ShortRecipes.Count; i++)
   {
        if (Model.IsRecipeDisplayed[i])
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e8e8cb50c4f05729df9278843bad070c1a491ee17597", async() => {
                WriteLiteral("\r\n                <div class=\"thumbnail card shadow mb-5\">\r\n                    <div class=\"clearfix\">\r\n                        <img");
                BeginWriteAttribute("src", " src=\"", 1081, "\"", 1115, 1);
#nullable restore
#line 31 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
WriteAttributeValue("", 1087, Model.ShortRecipes[i].Image, 1087, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                BeginWriteAttribute("alt", " alt=\"", 1116, "\"", 1150, 1);
#nullable restore
#line 31 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
WriteAttributeValue("", 1122, Model.ShortRecipes[i].Title, 1122, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" style=\"width:30%\" class=\"float-left mr-2\">\r\n                        <h5 class=\"mt-3\">");
#nullable restore
#line 32 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                    Write(Model.ShortRecipes[i].Title);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                        <p class=\"mt-3\">\r\n                            <strong>Missed Ingredients:</strong>\r\n");
#nullable restore
#line 35 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                             for (var j = 0; j < Model.ShortRecipes[i].MissedIngredients.Count; j++)
                            {
                                if (i != Model.ShortRecipes[i].MissedIngredients.Count - 1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span>");
#nullable restore
#line 39 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                     Write(Model.ShortRecipes[i].MissedIngredients[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(", </span>\r\n");
#nullable restore
#line 40 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span>");
#nullable restore
#line 43 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                     Write(Model.ShortRecipes[i].MissedIngredients[j].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 44 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </p>\r\n                        <p class=\"mt-3\">\r\n                            <strong>Used Ingredients:</strong>\r\n");
#nullable restore
#line 49 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                             for (var k = 0; k < Model.ShortRecipes[i].UsedIngredientCount; k++)
                            {
                                if (k != Model.ShortRecipes[i].UsedIngredientCount - 1)
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span>");
#nullable restore
#line 53 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                     Write(Model.ShortRecipes[i].UsedIngredients[k].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral(", </span>\r\n");
#nullable restore
#line 54 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                    <span>");
#nullable restore
#line 57 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                     Write(Model.ShortRecipes[i].UsedIngredients[k].Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
#nullable restore
#line 58 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                }
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </p>\r\n                    <p>Cook time: ");
#nullable restore
#line 61 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                             Write(Model.Recipes[i].ReadyInMinutes);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>Vegan: ");
#nullable restore
#line 62 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                         Write(Model.Recipes[i].Vegan);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>Gluten Free: ");
#nullable restore
#line 63 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                               Write(Model.Recipes[i].GlutenFree);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>Dairy Free: ");
#nullable restore
#line 64 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                              Write(Model.Recipes[i].DairyFree);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                    <p>Healthy?: ");
#nullable restore
#line 65 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                            Write(Model.Recipes[i].VeryHealthy);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_8.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_8);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_9.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-recipeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                                                                 WriteLiteral(Model.ShortRecipes[i].Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["recipeId"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-recipeId", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["recipeId"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 69 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <!-- If there is no record shown, a message would be displayed -->\r\n");
#nullable restore
#line 73 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
      
        int n = 0;
        foreach (bool b in @Model.IsRecipeDisplayed)
        {
            if (b)
            {
                n++;
            }
        }
        if (n == 0)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <h3>Sorry, no recipes match. Please change filter criterion.</h3>\r\n");
#nullable restore
#line 85 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
        }
    

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ResultPageViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
