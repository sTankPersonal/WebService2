using BuildingBlocks.SharedKernel.DomainServices;
using BuildingBlocks.SharedKernel.Repositories;
using Identity.Application.DTOs.Category;

namespace Identity.Application.Interfaces.Services
{
    public interface ICategoryService : IDomainService<Guid>
    {
        Task<PagedResult<CategoryDto>> GetAllAsync(int pageNumber, int pageSize, string searchName);
        Task<CategoryDto> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(CreateCategoryDto createCategoryDto);
        Task UpdateAsync(Guid id, UpdateCategoryDto updateCategoryDto);
        Task DeleteAsync(Guid id);
    }
}
