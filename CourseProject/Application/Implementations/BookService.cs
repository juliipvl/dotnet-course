using Core.Models;
using Application.Abstractions;
using Core.IRepositories;

namespace Application.Implementations
{
    public class BookService : IBookService
    {
        private readonly IRepository<Book> _repository;

        public BookService(IRepository<Book> repository)
        {
            _repository = repository;
        }

        public async Task<List<Book>> GetFilterBooksAsync(Func<string, bool> filter)
        {
            var books = await _repository.GetAllAsync();
            return books.FindAll(book => filter(book.Author));
        }

        public Task PublishAsync(Book book)
        {
            throw new NotImplementedException();
        }

        public Task<List<Book>> ViewAsync()
        {
            throw new NotImplementedException();
        }
    }
}
