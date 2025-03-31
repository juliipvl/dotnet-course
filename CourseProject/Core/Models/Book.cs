namespace Core.Models
{
    public class Book: IEntity
    {
        public Guid Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get ; set; }

        public Recipe[] Recipes  { get; set; }    
    }
}
