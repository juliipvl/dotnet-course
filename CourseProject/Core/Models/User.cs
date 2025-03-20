namespace Core.Models
{
    public class User
    {
        public long Id { get; set; }

        public string Name { get; set; }

        public List<Book> PublishedRecipeBooks { get; set; } 
    }
}
