using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICarRentalService
    {
        Task<List<CarRental>> GetAll();
        Task<CarRental> GetById(int id);
        Task Create(CarRental model);
        Task Update(CarRental model);
        Task Delete(int id);
    }
}