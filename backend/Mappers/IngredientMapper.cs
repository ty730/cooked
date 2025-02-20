using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class IngredientMapper
{
    public static IngredientDto ToIngredientDto(this Ingredient ingredientModel)
    {
        return new IngredientDto
        {
            Id = ingredientModel.Id,
            FoodId = ingredientModel.FoodId,
            Unit = ingredientModel.Unit,
            Amount = ingredientModel.Amount
        };
    }
}
}