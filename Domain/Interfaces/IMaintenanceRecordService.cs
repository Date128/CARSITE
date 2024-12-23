using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IMaintenanceRecordService
    {

        Task<List<MaintenanceRecord>> GetAll();
        Task<MaintenanceRecord> GetById(int id);
        Task Create(MaintenanceRecord model);
        Task Update(MaintenanceRecord model);
        Task Delete(int id);
    }
}