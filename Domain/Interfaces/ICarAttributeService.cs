using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICarAttributeService
    {
        Task<List<CarAttribute>> GetAll();
        Task<CarAttribute> GetById(int carId, int attributeId);
        Task Create(CarAttribute model);
        Task Update(CarAttribute model);
        Task Delete(int carId, int attributeId);
    }
}