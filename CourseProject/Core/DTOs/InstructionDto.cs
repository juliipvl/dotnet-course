using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.DTOs
{
    public class InstructionDto : BaseModelDto
    {
        public int StepNumber { get; set; }
        public string Description { get; set; }
    }
}
