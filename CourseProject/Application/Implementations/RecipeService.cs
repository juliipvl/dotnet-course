using Core.Models;
using Application.Abstractions;
using Core.IRepositories;

namespace Application.Implementations
{
    public class RecipeService : IRecipeService
    {
        private readonly IRepository<Recipe> _repository;

        public RecipeService(IRepository<Recipe> repository)
        {
            _repository = repository;
        }
        public void Read(Book book)
        {
            throw new NotImplementedException();
        }

    }
}
