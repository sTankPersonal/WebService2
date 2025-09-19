using BuildingBlocks.SharedKernel.Entities;
using Identity.Domain.Aggregates;

namespace Identity.Domain.Entities
{
    public class RecipeIngredient : BaseEntity<Guid>
    {
        public Guid RecipeId { get; set; } = default!;
        public Guid IngredientId { get; set; } = default!;
        public Guid UnitId { get; set; } = default!;
        public required Recipe Recipe { get; set; }
        public required Ingredient Ingredient { get; set; }
        public required Unit Unit { get; set; }
        public decimal Quantity { get; set; }
    }
}
