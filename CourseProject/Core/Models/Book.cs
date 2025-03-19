using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Book
    {
        public long Id { get; set; }

        public string Title { get; set; }

        public string Author { get; set; }

        public string Description { get ; set; }

        public Recipe[] Recipes  { get; set; }    
    }
}
