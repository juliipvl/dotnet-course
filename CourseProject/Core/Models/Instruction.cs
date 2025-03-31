namespace Core.Models
{
    public class Instruction: IEntity
    {
        public Guid Id { get; set; }

        public int StepNumber { get; set; } 

        public string Description { get; set; } 
    }
}
