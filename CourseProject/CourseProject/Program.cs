using Application.Abstractions;
using Infrastructure.Helpers;
using Microsoft.Extensions.DependencyInjection;


namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var provider = ServiceConfigurator.Configure();

            var userService = provider.GetRequiredService<IUserService>();
            var bookService = provider.GetRequiredService<IBookService>();

            userService.GetUserById(id => id == Guid.Empty);
            bookService.GetFilterBooks(id => id == "");
        }
    }
}
