using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IServiceCenterService
    {
        Task<List<ServiceCenter>> GetAll();
        Task<ServiceCenter> GetById(int id);
        Task Create(ServiceCenter model);
        Task Update(ServiceCenter model);
        Task Delete(int id);
    }
}