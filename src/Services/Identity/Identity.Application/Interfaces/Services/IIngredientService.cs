using BuildingBlocks.SharedKernel.DomainServices;
using BuildingBlocks.SharedKernel.Repositories;
using Identity.Application.DTOs.Ingredient;

namespace Identity.Application.Interfaces.Services
{
    public interface IIngredientService : IDomainService<Guid>
    {
        Task<PagedResult<IngredientDto>> GetAllAsync(int pageNumber, int pageSize, string searchName);
        Task<IngredientDto> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(CreateIngredientDto createIngredientDto);
        Task UpdateAsync(Guid id, UpdateIngredientDto updateIngredientDto);
        Task DeleteAsync(Guid id);
    }
}
