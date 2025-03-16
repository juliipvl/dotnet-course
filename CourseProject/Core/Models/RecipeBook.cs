using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class RecipeBook
    {
        private string _title;
        private string _author;
        private string _description;
        private Recipe[] _recipes;

        public string Title 
        { 
            get => _title;
            set => _title = value; 
        }
        public string Author 
        { 
            get => _author; 
            set => _author = value; 
        }
        public string Description 
        { 
            get => _description;
            set => _description = value; 
        }
        public Recipe[] Recipes 
        { 
            get => _recipes;  
            set => _recipes = value; 
        }    
    }
}
