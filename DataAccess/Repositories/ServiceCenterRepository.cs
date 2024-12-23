using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class ServiceCenterRepository : RepositoryBase<ServiceCenter>, IServiceCenterRepository
    {
        public ServiceCenterRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}