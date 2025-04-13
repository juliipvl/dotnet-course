using Core.Mappers;
using Core.Models;

namespace CourseProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var originalRecipe = new Recipe
            {
                Id = Guid.NewGuid(),
                Title = "Test Pizza",
                Ingredients = new List<Ingredient>
                    {
                        new Ingredient { Name = "Tomato", Quantity = 2, Unit = "pcs" }
                    },
                Instructions = new List<Instruction>
                    {
                        new Instruction { StepNumber = 1, Description = "Slice tomatoes" }
                    }
            };

            var dto = RecipeMapper.MapToDto(originalRecipe);
            var mappedBack = RecipeMapper.MapToModel(dto);

            Console.WriteLine($"ID OK: {originalRecipe.Id == mappedBack.Id}");
            Console.WriteLine($"Title OK: {originalRecipe.Title == mappedBack.Title}");
            Console.WriteLine($"Ingredients Count OK: {originalRecipe.Ingredients.Count == mappedBack.Ingredients.Count}");
            Console.WriteLine($"First Ingredient Name OK: {originalRecipe.Ingredients[0].Name == mappedBack.Ingredients[0].Name}");
            Console.WriteLine($"Step 1 Description OK: {originalRecipe.Instructions[0].Description == mappedBack.Instructions[0].Description}");
        }
    }
}
