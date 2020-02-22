using System;
using System.Collections.Generic;

namespace Blazor.Fun.Hosted.Shared.Models
{
    public class Recipe
    {
        public string Title { get; set; }

        public string Description { get; set; }

        public List<Ingredient> Ingredients { get; set; }
    }
}