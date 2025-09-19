using BuildingBlocks.SharedKernel.Repositories;
using Identity.Domain.Entities;

namespace Identity.Domain.Interfaces.Repositories
{
    public interface IIngredientRepository<TId> : IRepository<Ingredient<TId>>
    {
    }
}
