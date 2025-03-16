using Application.Implementations;
using Core.Models;

namespace Application.Abstractions
{
    public interface IRecipeBookService
    {
        void Publish(RecipeBook recipeBook);
        void Read(RecipeBook recipeBook);
        void View();

        List<RecipeBook> FilterBooks(Predicate<RecipeBook> filter);
    }
}
