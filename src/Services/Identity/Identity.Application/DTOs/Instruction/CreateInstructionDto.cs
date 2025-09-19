namespace Identity.Application.DTOs.Instruction
{
    public class CreateInstructionDto
    {
        public string Description { get; set; } = string.Empty;
        public int StepNumber { get; set; }
    }
}
