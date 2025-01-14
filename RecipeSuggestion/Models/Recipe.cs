﻿using System.Collections.Generic;

namespace RecipeSuggestion.Models
{
	public class Recipe
	{
        public bool Vegetarian { get; set; }

        public bool Vegan { get; set; }

        public bool GlutenFree { get; set; }

        public bool DairyFree { get; set; }

        public bool VeryHealthy { get; set; }

        public bool Cheap { get; set; }

        public bool VeryPopular { get; set; }

        public bool Sustainable { get; set; }

        public int WeightWatcherSmartPoints { get; set; }

        public string Gaps { get; set; }

        public bool LowFodmap { get; set; }

        public int AggregateLikes { get; set; }

        public double SpoonacularScore { get; set; }

        public double HealthScore { get; set; }

        public string CreditsText { get; set; }

        public string License { get; set; }

        public string SourceName { get; set; }

        public double PricePerServing { get; set; }

        public List<ExtendedIngredient> ExtendedIngredients { get; set; }

        public int Id { get; set; }

        public string Title { get; set; }

        public int ReadyInMinutes { get; set; }

        // how many dishes you cook with this recipe
        public int Servings { get; set; }

        public string SourceUrl { get; set; }

        public string Image { get; set; }

        public string ImageType { get; set; }

        public string Summary { get; set; }

        public List<string> Cuisines { get; set; }

        public List<string> DishTypes { get; set; }

        public List<string> Diets { get; set; }

        public List<object> Occasions { get; set; }

        public string Instructions { get; set; }

        public List<AnalyzedInstruction> AnalyzedInstructions { get; set; }

        public object OriginalId { get; set; }

        public string SpoonacularSourceUrl { get; set; }
    }
}
