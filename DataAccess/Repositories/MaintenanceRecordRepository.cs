using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class MaintenanceRecordRepository : RepositoryBase<MaintenanceRecord>, IMaintenanceRecordRepository
    {
        public MaintenanceRecordRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}