using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class PantryMapper
    {
        public static PantryDto ToPantryDto(this Pantry pantryModel)
        {
            return new PantryDto
            {
                Id = pantryModel.Id,
                Ingredients = pantryModel.Ingredients,
                Meals = pantryModel.Meals
            };
        }
    }

}