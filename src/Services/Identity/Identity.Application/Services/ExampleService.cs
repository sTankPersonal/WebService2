
using BuildingBlocks.SharedKernel.DomainServices;
using BuildingBlocks.SharedKernel.Repositories;

namespace Identity.Application.Services
{
    public class ExampleService(IRepository ExampleRepository) : IDomainService
    {

    }
}
