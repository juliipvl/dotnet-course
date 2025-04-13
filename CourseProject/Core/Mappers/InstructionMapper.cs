using Core.DTOs;
using Core.Models;

namespace Core.Mappers
{
    public static class InstructionMapper
    {
        public static InstructionDto MapToDto(this Instruction instruction)
        {
            return new InstructionDto
            {
                Id = instruction.Id,
                StepNumber = instruction.StepNumber,
                Description = instruction.Description
            };
        }

        public static Instruction MapToModel(this InstructionDto dto)
        {
            return new Instruction
            {
                Id = dto.Id,
                StepNumber = dto.StepNumber,
                Description = dto.Description
            };
        }
    }
}
