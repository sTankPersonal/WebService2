using BuildingBlocks.SharedKernel.Entities;
using Identity.Domain.Aggregates;

namespace Identity.Domain.Entities
{
    public class Instruction : BaseEntity<Guid>
    {
        public int StepNumber { get; set; }
        public string StepDirection { get; set; } = string.Empty;
        public Guid RecipeId { get; set; } = default!;
        public required Recipe Recipe { get; set; }
    }
}
