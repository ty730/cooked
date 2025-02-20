using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class FoodMapper
{
    public static FoodDto ToFoodDto(this Food foodModel)
    {
        return new FoodDto
        {
            Id = foodModel.Id,
            Name = foodModel.Name,
            DefaultUnit = foodModel.DefaultUnit,
            DefaultAmount = foodModel.DefaultAmount,
            Cost = foodModel.Cost,
            Calories = foodModel.Calories,
            Fiber = foodModel.Fiber,
            Protein = foodModel.Protein,
            TotalSugar = foodModel.TotalSugar,
            Sodium = foodModel.Sodium
        };
    }
}
}