using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Models
{
    public class Ingredient
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public string Unit { get; set; } = string.Empty;
        public double Amount { get; set; }
    }
}