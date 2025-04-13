using Core.DTOs;
using Core.Models;

namespace Core.Mappers
{
    public static class RecipeMapper
    {
        public static RecipeDto MapToDto(this Recipe recipe)
        {
            return new RecipeDto
            {
                Id = recipe.Id,
                Title = recipe.Title,
                Ingredients = recipe.Ingredients.Select(IngredientMapper.MapToDto).ToList(),
                Instructions = recipe.Instructions.Select(InstructionMapper.MapToDto).ToList()
            };
        }

        public static Recipe MapToModel(this RecipeDto dto)
        {
            return new Recipe
            {
                Id = dto.Id,
                Title = dto.Title,
                Ingredients = dto.Ingredients.Select(IngredientMapper.MapToModel).ToList(),
                Instructions = dto.Instructions.Select(InstructionMapper.MapToModel).ToList()
            };
        }
    }
}
