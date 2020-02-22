using System.Collections.Generic;
using RecipesLib.Recipe.Models;

namespace RecipesLib.Recipe.Pages
{
    public partial class Recipes
    {
        public List<RecipesLib.Recipe.Models.Recipe> RecipesList { get; set; }

        public Recipes()
        {
            RecipesList = new List<RecipesLib.Recipe.Models.Recipe>
            {
                new RecipesLib.Recipe.Models.Recipe
                {
                    Title = "Borsch",
                    Description = "Ukrainian national meal",
                    Ingredients = new List<Ingredient>
                    {
                        new Ingredient {Title = "Potato", Amount = 4},
                        new Ingredient {Title = "Tomato", Amount = 10},
                        new Ingredient {Title = "Cabbage", Amount = 1}
                    }
                }
            };
        }
    }
}