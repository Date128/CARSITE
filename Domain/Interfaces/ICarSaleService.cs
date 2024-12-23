using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICarSaleService
    {
        Task<List<CarSale>> GetAll();
        Task<CarSale> GetById(int id);
        Task Create(CarSale model);
        Task Update(CarSale model);
        Task Delete(int id);
    }
}