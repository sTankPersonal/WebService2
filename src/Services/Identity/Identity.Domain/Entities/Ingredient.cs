using BuildingBlocks.SharedKernel.Entities;
using System.Security.Cryptography;

namespace Identity.Domain.Entities
{
    public class Ingredient : BaseEntity<Guid>
    {
        public string Name { get; set; } = string.Empty;
        public ICollection<RecipeIngredient> RecipeIngredients { get; set; } = [];
    }
}
