#pragma checksum "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "60c093ac1fa9e6faa01a495e0d161997d84c7def"
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
#line 1 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using RecipeSuggestion.Models.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60c093ac1fa9e6faa01a495e0d161997d84c7def", @"/Views/Home/Result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0c01cfe949fe35887b9c045e9ef2e2f5e2e69041", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ShortRecipe>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"container\">\r\n");
#nullable restore
#line 3 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
     foreach (ShortRecipe recipe in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"thumbnail card shadow mb-5\">\r\n            <div class=\"clearfix\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 208, "\"", 227, 1);
#nullable restore
#line 7 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
WriteAttributeValue("", 214, recipe.Image, 214, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 228, "\"", 247, 1);
#nullable restore
#line 7 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
WriteAttributeValue("", 234, recipe.Title, 234, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:30%\" class=\"float-left mr-2\">\r\n                <h5 class=\"mt-3\">");
#nullable restore
#line 8 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                            Write(recipe.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <p class=\"mt-3\">\r\n                    <strong>Missed Ingredients:</strong>\r\n");
#nullable restore
#line 11 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                     for (var i = 0; i < recipe.MissedIngredients.Count; i++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                   Write(recipe.MissedIngredients[i].Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                         if (i < recipe.MissedIngredients.Count - 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>,</span>\r\n");
#nullable restore
#line 17 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n                <p class=\"mt-3\">\r\n                    <strong>Used Ingredients:</strong>\r\n");
#nullable restore
#line 22 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                     for (var i = 0; i < recipe.UsedIngredientCount; i++)
                    {
                        

#line default
#line hidden
#nullable disable
#nullable restore
#line 24 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                   Write(recipe.UsedIngredients[i].Name);

#line default
#line hidden
#nullable disable
#nullable restore
#line 25 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                         if (i < recipe.UsedIngredients.Count - 1)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <span>,</span>\r\n");
#nullable restore
#line 28 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 28 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
                         
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </p>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 33 "C:\Users\juho1\OneDrive\바탕 화면\Recipe\RecipeSuggestion\RecipeSuggestion\Views\Home\Result.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ShortRecipe>> Html { get; private set; }
    }
}
#pragma warning restore 1591
