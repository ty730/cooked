using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Dtos
{
    public class PantryDto
    {
        public int Id { get; set; }
        public List<Ingredient> Ingredients { get; set; } = new List<Ingredient>();
        public List<Meal> Meals { get; set; } = new List<Meal>();
    }
}