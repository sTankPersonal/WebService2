using BuildingBlocks.SharedKernel.Entities;
using Identity.Domain.Aggregates;

namespace Identity.Domain.Entities
{
    public class RecipeCategory : BaseEntity<Guid>
    {
        public Guid RecipeId { get; set; } = default!;
        public Guid CategoryId { get; set; } = default!;
        public required Recipe Recipe { get; set; }
        public required Category Category { get; set; }
    }
}
