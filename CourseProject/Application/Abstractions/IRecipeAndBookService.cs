using Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Abstractions
{
    public interface IRecipeAndBookService
    {
        void Publish();
        void View();
        void Read();
    }
}
