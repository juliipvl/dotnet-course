using Core.Models;

namespace Application.Abstractions
{
    public interface IRecipeService
    {
        Task ReadAsync(Book book);
    }
}
