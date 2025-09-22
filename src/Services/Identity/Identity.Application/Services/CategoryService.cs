using BuildingBlocks.SharedKernel.Repositories;
using Identity.Application.DTOs.Category;
using Identity.Application.Interfaces.Services;

namespace Identity.Application.Services
{
    public class CategoryService : ICategoryService
    {
        public Task<Guid> CreateAsync(CreateCategoryDto createCategoryDto)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task<PagedResult<CategoryDto>> GetAllAsync(int pageNumber, int pageSize, string searchName)
        {
            throw new NotImplementedException();
        }

        public Task<CategoryDto> GetByIdAsync(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Guid id, UpdateCategoryDto updateCategoryDto)
        {
            throw new NotImplementedException();
        }
    }
}
