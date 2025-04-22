using Core.Models;

namespace Application.Abstractions
{
    public interface IBookService
    {
        Task PublishAsync(Book book);

        Task<List<Book>> ViewAsync();

        Task<List<Book>> GetFilterBooksAsync(Func<string, bool> filter);
    }
}
