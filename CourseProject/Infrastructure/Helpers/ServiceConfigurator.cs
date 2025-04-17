using Application.Abstractions;
using Application.Implementations;
using Core.IRepositories;
using Microsoft.Extensions.DependencyInjection;
using Infrastructure.Repositories;
using Infrastructure.Services;

namespace Infrastructure.Helpers
{
    public static class ServiceConfigurator
    {
        public static ServiceProvider Configure()
        {
            var services = new ServiceCollection();

            services.AddSingleton(typeof(IRepository<>), typeof(Repository<>));

            services.AddSingleton(provider =>
            {
                var dataDirectory = "Data"; 
                return new JsonService(dataDirectory);
            });

            services.AddSingleton<IUserService, UserService>();
            services.AddSingleton<IRecipeService, RecipeService>();
            services.AddSingleton<IBookService, BookService>();

            return services.BuildServiceProvider();
        }
    }
}
