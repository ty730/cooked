using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Dtos
{
    public class MealDto
    {
        public int Id { get; set; }
        public int RecipeId { get; set; }
        public double PercentOfRecipe { get; set; }
        public List<Ingredient> SnackIngredients { get; set; } = new List<Ingredient>();
        public DateTime Prepared { get; set; }
        public DateTime Eaten { get; set; }
        public DateTime Planned { get; set; }
    }
}