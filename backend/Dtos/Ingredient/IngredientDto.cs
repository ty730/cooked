using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace backend.Dtos
{
    public class IngredientDto
    {
        public int Id { get; set; }
        public int FoodId { get; set; }
        public string Unit { get; set; } = string.Empty;
        public double Amount { get; set; }
    }
}