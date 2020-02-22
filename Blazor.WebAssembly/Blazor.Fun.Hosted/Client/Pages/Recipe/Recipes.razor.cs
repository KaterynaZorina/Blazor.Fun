using System.Collections.Generic;
using Blazor.Fun.Hosted.Shared.Models;

namespace Blazor.Fun.Hosted.Client.Pages.Recipe
{
    public partial class Recipes
    {
        public List<Hosted.Shared.Models.Recipe> RecipesList { get; set; }

        public Recipes()
        {
            RecipesList = new List<Hosted.Shared.Models.Recipe>
            {
                new Hosted.Shared.Models.Recipe
                {
                 Title   = "Borsch",
                 Description = "Ukrainian national meal",
                 Ingredients = new List<Ingredient>
                 {
                     new Ingredient {Title = "Potato", Amount = 4},
                     new Ingredient{Title = "Tomato", Amount = 10},
                     new Ingredient{Title = "Cabbage", Amount = 1}
                 }
                }
            };
        }
    }
}