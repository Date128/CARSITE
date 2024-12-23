using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITechnicalMaintenanceService
    {
        Task<List<TechnicalMaintenance>> GetAll();
        Task<TechnicalMaintenance> GetById(int id);
        Task Create(TechnicalMaintenance model);
        Task Update(TechnicalMaintenance model);
        Task Delete(int id);
    }
}