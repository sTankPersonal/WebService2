using BuildingBlocks.SharedKernel.Repositories;
using Identity.Domain.Aggregates;

namespace Identity.Domain.Interfaces.Repositories
{
    public interface IRecipeRepository<TId> : IRepository<Recipe>
    {
    }
}
