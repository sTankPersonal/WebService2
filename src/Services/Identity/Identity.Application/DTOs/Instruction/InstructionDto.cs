namespace Identity.Application.DTOs.Instruction
{
    public class InstructionDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; } = string.Empty;
        public int StepNumber { get; set; }
    }
}
