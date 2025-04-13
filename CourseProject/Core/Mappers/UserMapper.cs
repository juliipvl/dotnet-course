using Core.DTOs;
using Core.Models;

namespace Core.Mappers
{
    public static class UserMapper
    {
        public static UserDto MapToDto(this User user)
        {
            return new UserDto
            {
                Id = user.Id,
                Name = user.Name,
                PublishedRecipeBooks = user.PublishedRecipeBooks.Select(BookMapper.MapToDto).ToList()
            };
        }

        public static User MapToModel(this UserDto dto)
        {
            return new User
            {
                Id = dto.Id,
                Name = dto.Name,
                PublishedRecipeBooks = dto.PublishedRecipeBooks.Select(BookMapper.MapToModel).ToList()
            };
        }
    }
}
