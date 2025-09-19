using BuildingBlocks.SharedKernel.Entities;

namespace Identity.Domain.Entities
{
    public class Category : BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<RecipeCategory> RecipeCategories { get; set; } = [];
    }
}
