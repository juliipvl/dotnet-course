using Core.Models;
using Application.Abstractions;


namespace Application.Implementations
{
    // Another possible implementation of IRecipeBookService
    public class MealRecipeService : IRecipeBookService
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
