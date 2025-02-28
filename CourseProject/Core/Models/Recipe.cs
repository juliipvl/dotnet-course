using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Recipe
    {
        private string _title;
        private List<string> _ingredients;
        private string _instructions;

        public string Title 
        {   
            get { return _title; } 
            set { _title = value; } 
        }
        public List<string> Ingredients 
        { 
            get { return new List<string>(_ingredients); } 
            set { _ingredients = new List<string>(value); } 
        }
        public string Instructions 
        { 
            get { return _instructions; } 
            set { _instructions = value; } 
        }
    }
}
