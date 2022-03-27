#pragma checksum "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b13b5ff301efee1393a3d3e1bc2ab662ce3e4f7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_SavedRecipe), @"mvc.1.0.view", @"/Views/Home/SavedRecipe.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b13b5ff301efee1393a3d3e1bc2ab662ce3e4f7", @"/Views/Home/SavedRecipe.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c01cfe949fe35887b9c045e9ef2e2f5e2e69041", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_SavedRecipe : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Recipe>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Detail", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RemoveRecipeFromSaveList", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("<h1>Saved Recipe</h1>\r\n\r\n<p>");
#nullable restore
#line 4 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml"
Write(TempData["SavedRecipeMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<!-- Back-end processing, please contact Huy before modifing -->\r\n");
#nullable restore
#line 6 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml"
  
    // if there is actually at least 1 recipe
    if (Model.Count>0){
        foreach (Recipe recipe in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b13b5ff301efee1393a3d3e1bc2ab662ce3e4f75136", async() => {
#nullable restore
#line 11 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml"
                                                            Write(recipe.Title);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-recipeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 11 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml"
                                          WriteLiteral(recipe.Id);

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
            WriteLiteral("\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1b13b5ff301efee1393a3d3e1bc2ab662ce3e4f77618", async() => {
                WriteLiteral("Remove this recipe");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-recipeId", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 12 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml"
                                                            WriteLiteral(recipe.Id);

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
#line 13 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml"
            // HTML code here
        }
    }
    // in case no recipes are in save list
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>Hmm, you have not saved any recipes yet. Please try to save one.</p>\r\n");
#nullable restore
#line 20 "C:\Conestoga\Application Project (INFO2310)\RecipeSuggestion\RecipeSuggestion\RecipeSuggestion\Views\Home\SavedRecipe.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- ---------- -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Recipe>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
