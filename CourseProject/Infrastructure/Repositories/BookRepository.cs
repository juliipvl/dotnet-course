using Core.Models;

namespace Infrastructure.Repositories
{
    public class BookRepository : Repository<Book>
    {
        public BookRepository(JsonService jsonService) : base(jsonService)
        {
        }
    }
}