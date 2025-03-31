using Core.Models;

namespace Infrastructure.Repositories
{
    public class RecipeRepository : Repository<Recipe>
    {
        public RecipeRepository(JsonService jsonService) : base(jsonService)
        {
        }
    }
}
