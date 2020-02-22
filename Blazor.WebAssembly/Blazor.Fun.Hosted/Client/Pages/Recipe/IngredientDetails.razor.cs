using Blazor.Fun.Hosted.Shared.Models;
using Microsoft.AspNetCore.Components;

namespace Blazor.Fun.Hosted.Client.Pages.Recipe
{
    public partial class IngredientDetails
    {
        [Parameter]
        public Ingredient Ingredient { get; set; }
    }
}