using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class IngredientListMapper
{
    public static IngredientListDto ToIngredientListDto(this IngredientList ingredientListModel)
    {
        return new IngredientListDto
        {
            Id = ingredientListModel.Id,
            Ingredients = ingredientListModel.Ingredients,
            Cost = ingredientListModel.Cost,
            Calories = ingredientListModel.Calories,
            Fiber = ingredientListModel.Fiber,
            Protein = ingredientListModel.Protein,
            TotalSugar = ingredientListModel.TotalSugar,
            Sodium = ingredientListModel.Sodium,
            Fat = ingredientListModel.Fat
        };
    }
}
}