using BuildingBlocks.SharedKernel.Repositories;
using Identity.Domain.Entities;

namespace Identity.Domain.Interfaces.Repositories
{
    public interface IUnitRepository<TId> : IRepository<Unit>
    {
    }
}
