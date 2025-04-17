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
        
        public List<Book> GetFilterBooks(Func<string, bool> filter)
        {
            return _repository.GetAll().Where(book => filter(book.Author)).ToList();
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
