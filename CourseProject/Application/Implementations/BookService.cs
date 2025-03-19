using Core.Models;
using Application.Abstractions;


namespace Application.Implementations
{
    public class BookService : IBookService
    {
        public List<Book> GetFilterBooks(Func<string, bool> filter)
        {
            return new List<Book>().FindAll((book) => filter(book.Author));
        }

        public void Publish(Book book)
        {
            throw new NotImplementedException();
        }

        public List<Book> View()
        {
            throw new NotImplementedException();
        }
    }
}
