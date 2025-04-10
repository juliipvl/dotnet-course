namespace Core.Models
{
    public class Recipe: BaseModel
    {
        public string Title { get;  set; }

        public List<Ingredient> Ingredients { get; set; } 

        public List<Instruction> Instructions { get; set; } 
    }
}
