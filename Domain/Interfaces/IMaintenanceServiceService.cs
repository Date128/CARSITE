using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IMaintenanceServiceService
    {
        Task<List<MaintenanceService>> GetAll();
        Task<MaintenanceService> GetById(int id);
        Task Create(MaintenanceService model);
        Task Update(MaintenanceService model);
        Task Delete(int id);
    }
}