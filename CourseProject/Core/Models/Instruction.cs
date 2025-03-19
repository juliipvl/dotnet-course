using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Models
{
    public class Instruction
    {
        public long Id { get; set; }

        public int StepNumber { get; set; } 

        public string Description { get; set; } 
    }
}
