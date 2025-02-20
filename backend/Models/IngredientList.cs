using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class IngredientList
    {
        public int Id { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public double Cost { get; set; }
        public double Calories { get; set; }
        public double Fiber { get; set; }
        public double Protein { get; set; }
        public double TotalSugar { get; set; }
        public double Sodium { get; set; }
        public double Fat { get; set; }
    }
}