using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class BookDto : BaseModelDto
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public string Description { get; set; }
        public List<RecipeDto> Recipes { get; set; }
    }
}
