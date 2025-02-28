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
            get { return _title; } 
            set { string _title; } 
        }
        public string Author 
        { 
            get { return _author; } 
            set { _author = value; } 
        }
        public string Description 
        { 
            get { return _description; } 
            set { _description = value; } 
        }
        public Recipe[] Recipes 
        { 
            get { return _recipes; } 
            set { _recipes = value; } 
        }    
    }
}
