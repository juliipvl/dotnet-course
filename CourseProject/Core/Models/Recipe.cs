namespace Core.Models
{
    public class Recipe: IEntity
    {
        public Guid Id { get; set; }

        public string Title { get;  set; }

        public List<Ingredient> Ingredients { get; set; } 

        public List<Instruction> Instructions { get; set; } 
    }
}
