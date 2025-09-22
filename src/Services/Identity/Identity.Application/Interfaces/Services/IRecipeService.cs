using BuildingBlocks.SharedKernel.DomainServices;
using BuildingBlocks.SharedKernel.Repositories;
using Identity.Application.DTOs.Recipe;

namespace Identity.Application.Interfaces.Services
{
    public interface IRecipeService
    {
        Task<PagedResult<RecipeDto>> GetAllAsync(int pageNumber, int pageSize, string searchName, string searchCategory, string searchIngredient);
        Task<RecipeDto> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(CreateRecipeDto createRecipeDto);
        Task UpdateAsync(Guid id, UpdateRecipeDto updateRecipeDto);
        Task DeleteAsync(Guid id);
    }
}
