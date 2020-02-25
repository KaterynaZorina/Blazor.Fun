using System.ComponentModel.DataAnnotations;

namespace RecipesLib.Recipe.Models
{
    public class Ingredient
    {
        [Required]
        [MaxLength(10)]
        public string Title { get; set; }

        [Required]
        public int Amount { get; set; }
    }
}