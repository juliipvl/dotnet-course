using Core.Models;
using Infrastructure.Repositories;

namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            JsonService jsonService = new JsonService("users");
            UserRepository userRepos = new UserRepository(jsonService);
            User user1 = new User() { Id = Guid.NewGuid(), Name = "yulka", PublishedRecipeBooks = new List<Book>() };
            userRepos.Add(user1);
        }
    }
}
