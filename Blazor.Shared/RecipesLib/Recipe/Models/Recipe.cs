using System.Collections.Generic;

namespace RecipesLib.Recipe.Models
{
    public class Recipe
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}