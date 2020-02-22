using Microsoft.AspNetCore.Components;
using RecipesLib.Recipe.Models;

namespace RecipesLib.Recipe.Pages
{
    public partial class IngredientDetails
    {
        [Parameter]
        public Ingredient Ingredient { get; set; }
    }
}