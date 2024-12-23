using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class TechnicalMaintenanceRepository : RepositoryBase<TechnicalMaintenance>, ITechnicalMaintenanceRepository
    {
        public TechnicalMaintenanceRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}