using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class MealMapper
{
    public static MealDto ToMealDto(this Meal mealModel)
    {
        return new MealDto
        {
            Id = mealModel.Id,
            RecipeId = mealModel.RecipeId,
            PercentOfRecipe = mealModel.PercentOfRecipe,
            SnackIngredients = mealModel.SnackIngredients,
            Prepared = mealModel.Prepared,
            Eaten = mealModel.Eaten,
            Planned = mealModel.Planned
        };
    }
}
}