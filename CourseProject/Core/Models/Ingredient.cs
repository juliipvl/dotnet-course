namespace Core.Models
{
    public class Ingredient: IEntity
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public double Quantity { get; set; } 

        public string Unit { get; set; } 
    }
}
