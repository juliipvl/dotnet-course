using Core.DTOs;
using Core.Models;

namespace Core.Mappers
{
    public static class BookMapper
    {
        public static BookDto MapToDto(this Book book)
        {
            return new BookDto
            {
                Id = book.Id,
                Title = book.Title,
                Author = book.Author,
                Description = book.Description,
                Recipes = book.Recipes.Select(RecipeMapper.MapToDto).ToList()
            };
        }

        public static Book MapToModel(this BookDto dto)
        {
            return new Book
            {
                Id = dto.Id,
                Title = dto.Title,
                Author = dto.Author,
                Description = dto.Description,
                Recipes = dto.Recipes.Select(RecipeMapper.MapToModel).ToArray()
            };
        }
    }
}
