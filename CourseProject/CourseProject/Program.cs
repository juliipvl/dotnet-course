using Application.Abstractions;
using Application.Implementations;
using Core.Models;

namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {

            UserService userService = new UserService();
            User user = userService.GetUserById((id) => id == 1);

            IBookService recipeBookService = new BookService();
            recipeBookService.GetFilterBooks((author) => author == "John Doe");
            recipeBookService.GetFilterBooks((title) => title == "Pancakes");
        }
    }
}
