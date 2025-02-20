using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Recipe
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string URL { get; set; } = string.Empty;
        public double ServingsYield { get; set; }
        public double PrepTime { get; set; }
        public double CookTime { get; set; }
        public double TotalTime { get; set; }
        public List<string> Instructions { get; set; } = new List<string>();
        public int IngredientListId { get; set; }
    }
}