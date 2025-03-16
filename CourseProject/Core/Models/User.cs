using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class User
    {
        public long UserId { get; set; }
        public string Name { get; set; }
        public List<RecipeBook> PublishedRecipeBooks { get; set; } = new List<RecipeBook>();
    }
}
