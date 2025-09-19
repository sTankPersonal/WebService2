using Identity.Application.DTOs.Category;
using Identity.Application.DTOs.Ingredient;
using Identity.Application.DTOs.Instruction;

namespace Identity.Application.DTOs.Recipe
{
    public class RecipeDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public IEnumerable<IngredientDto> Ingredients { get; set; } = [];
        public IEnumerable<CategoryDto> Categories { get; set; } = [];
        public IEnumerable<InstructionDto> Instructions { get; set; } = [];
    }
}
