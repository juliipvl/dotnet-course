using Core.Models;
using Infrastructure.Repositories;

namespace CourseProject
{
    internal class Program
    {
        static async Task Main(string[] args) 
        {
            var dataDir = "Data";
            var jsonService = new JsonService(dataDir);
            var recipeRepo = new Repository<Recipe>(jsonService, "recipes.json");

            var recipe = new Recipe
            {
                Id = Guid.NewGuid(),
                Title = "Pasta Carbonara",
                Ingredients = new List<Ingredient>
            {
                new Ingredient { Id = Guid.NewGuid(), Name = "Spaghetti", Quantity = 200, Unit = "grams" },
                new Ingredient { Id = Guid.NewGuid(), Name = "Eggs", Quantity = 2, Unit = "pieces" },
                new Ingredient { Id = Guid.NewGuid(), Name = "Parmesan Cheese", Quantity = 50, Unit = "grams" },
                new Ingredient { Id = Guid.NewGuid(), Name = "Bacon", Quantity = 100, Unit = "grams" }
            },
                Instructions = new List<Instruction>
            {
                new Instruction { Id = Guid.NewGuid(), StepNumber = 1, Description = "Boil spaghetti." },
                new Instruction { Id = Guid.NewGuid(), StepNumber = 2, Description = "Fry bacon." },
                new Instruction { Id = Guid.NewGuid(), StepNumber = 3, Description = "Mix eggs and cheese." },
                new Instruction { Id = Guid.NewGuid(), StepNumber = 4, Description = "Combine all and serve." }
            }
            };

            await recipeRepo.AddAsync(recipe); 
            Console.WriteLine("Recipe added.");

            var allRecipes = await recipeRepo.GetAllAsync(); 
            foreach (var r in allRecipes)
            {
                Console.WriteLine($"\nRecipe: {r.Title}");
                Console.WriteLine("Ingredients:");
                foreach (var ing in r.Ingredients)
                    Console.WriteLine($"- {ing.Quantity} {ing.Unit} {ing.Name}");

                Console.WriteLine("Instructions:");
                foreach (var ins in r.Instructions)
                    Console.WriteLine($"{ins.StepNumber}. {ins.Description}");
            }

            if (allRecipes.Count > 0)
            {
                var first = allRecipes[0];
                first.Title += " (Updated)";
                await recipeRepo.UpdateAsync(first); 
                Console.WriteLine("Recipe updated.");
            }
        }
    }
}
