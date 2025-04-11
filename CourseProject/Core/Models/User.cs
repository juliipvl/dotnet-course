namespace Core.Models
{
    public class User: BaseModel
    {
        public string Name { get; set; }

        public List<Book> PublishedRecipeBooks { get; set; } 
    }
}
