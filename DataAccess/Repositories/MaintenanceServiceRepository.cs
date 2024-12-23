using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class MaintenanceServiceRepository : RepositoryBase<MaintenanceService>, IMaintenanceServiceRepository
    {
        public MaintenanceServiceRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}