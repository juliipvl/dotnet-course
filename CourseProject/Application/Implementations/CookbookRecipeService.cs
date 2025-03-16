using Core.Models;
using Application.Abstractions;


namespace Application.Implementations
{
    public class CookbookRecipeService : IRecipeBookService
    {
        private List<RecipeBook> books = [new RecipeBook(), new RecipeBook(), new RecipeBook()];

        public List<RecipeBook> FilterBooks(Predicate<RecipeBook> filter)
        {
            return books.FindAll(filter);
        }

        public void Publish(RecipeBook recipeBook)
        {
            throw new NotImplementedException();
        }

        public void Read(RecipeBook recipeBook)
        {
            throw new NotImplementedException();
        }

        public void View()
        {
            throw new NotImplementedException();
        }
    }
}
