using BuildingBlocks.SharedKernel.DomainServices;
using BuildingBlocks.SharedKernel.Repositories;
using Identity.Application.DTOs.Instruction;

namespace Identity.Application.Interfaces.Services
{
    public interface IInstructionService : IDomainService<Guid>
    {
        Task<PagedResult<InstructionDto>> GetAllAsync(int pageNumber, int pageSize, string searchDescription);
        Task<InstructionDto> GetByIdAsync(Guid id);
        Task<Guid> CreateAsync(CreateInstructionDto createInstructionDto);
        Task UpdateAsync(Guid id, UpdateInstructionDto updateInstructionDto);
        Task DeleteAsync(Guid id);
    }
}
