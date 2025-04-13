using Core.DTOs;
using Core.Models;

namespace Core.Mappers
{
    public static class IngredientMapper
    {
        public static IngredientDto MapToDto(this Ingredient ingredient)
        {
            return new IngredientDto
            {
                Id = ingredient.Id,
                Name = ingredient.Name,
                Quantity = ingredient.Quantity,
                Unit = ingredient.Unit
            };
        }

        public static Ingredient MapToModel(this IngredientDto dto)
        {
            return new Ingredient
            {
                Id = dto.Id,
                Name = dto.Name,
                Quantity = dto.Quantity,
                Unit = dto.Unit
            };
        }
    }
}
