using BuildingBlocks.SharedKernel.DomainServices;
using BuildingBlocks.SharedKernel.Repositories;
using Identity.Application.DTOs.Unit;

namespace Identity.Application.Interfaces.Services
{
    public interface IUnitService : IDomainService<Guid>
    {
        Task<PagedResult<UnitDto>> GetAllAsync(int pageNumber, int pageSize, string searchName);
        Task<UnitDto> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(CreateUnitDto createUnitDto);
        Task UpdateAsync(Guid id, UpdateUnitDto updateUnitDto);
        Task DeleteAsync(Guid id);
    }
}
