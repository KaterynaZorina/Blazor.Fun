using Microsoft.AspNetCore.Components;

namespace RecipesLib.Recipe.Pages
{
    public partial class RecipeDetails
    {
        [Parameter]
        public RecipesLib.Recipe.Models.Recipe Recipe { get; set; }
    }
}