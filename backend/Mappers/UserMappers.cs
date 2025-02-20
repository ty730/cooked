using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using backend.Dtos;
using backend.Models;

namespace backend.Mappers
{
    public static class UserMappers
    {
        public static UserDto ToUserDto(this User userModel) {
            return new UserDto
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
                PantryId = userModel.PantryId,
                Recipes = userModel.Recipes,
                Meals = userModel.Meals,
                ShoppingListId = userModel.ShoppingListId
            };
        }
        public static User ToUserFromCreateDTO(this CreateUserRequestDto userModel) {
            return new User
            {
                FirstName = userModel.FirstName,
                LastName = userModel.LastName,
            };
        }
    }
}