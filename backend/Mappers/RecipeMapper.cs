using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class RecipeMapper
    {
        public static RecipeDto ToRecipeDto(this Recipe recipeModel)
        {
            return new RecipeDto
            {
                Id = recipeModel.Id,
                Name = recipeModel.Name,
                URL = recipeModel.URL,
                ServingsYield = recipeModel.ServingsYield,
                PrepTime = recipeModel.PrepTime,
                CookTime = recipeModel.CookTime,
                TotalTime = recipeModel.TotalTime,
                Instructions = recipeModel.Instructions,
                IngredientListId = recipeModel.IngredientListId
            };
        }
    }

}