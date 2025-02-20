using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Models;

namespace backend.Dtos
{
    public class UserDto
    {
        public int Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int PantryId { get; set; }
        public List<Recipe> Recipes { get; set; } = new List<Recipe>();
        public List<Meal> Meals { get; set; } = new List<Meal>();
        public IngredientList? ShoppingListId { get; set; } = new IngredientList();
    }
}