using Core.Models;

namespace Application.Abstractions
{
    public interface IBookService
    {
        void Publish(Book book);

        List<Book> View();

        List<Book> GetFilterBooks(Func<string, bool> filter);
    }
}
