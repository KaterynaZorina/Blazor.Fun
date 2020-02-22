using Microsoft.AspNetCore.Components;

namespace Blazor.Fun.Hosted.Client.Pages.Recipe
{
    public partial class RecipeDetails
    {
        [Parameter]
        public Hosted.Shared.Models.Recipe Recipe { get; set; }
    }
}