using Application.Abstractions;
using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Application.Implementations
{
    public class RecipeService : Application.Abstractions.IRecipeAndBookService
    {
        public List<RecipeBook> FilterBooks(Predicate<RecipeBook> filter)
        {
            throw new NotImplementedException();
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void View()
        {
            throw new NotImplementedException();
        }
    }

    public class BookService : Application.Abstractions.IRecipeAndBookService
    {
        private List<RecipeBook> books = [new RecipeBook(), new RecipeBook(), new RecipeBook()];

        public List<RecipeBook> FilterBooks(Predicate<RecipeBook> filter)
        {
            return books.FindAll(filter);
        }

        public void Publish()
        {
            throw new NotImplementedException();
        }

        public void Read()
        {
            throw new NotImplementedException();
        }

        public void View()
        {
            throw new NotImplementedException();
        }

    }
}
