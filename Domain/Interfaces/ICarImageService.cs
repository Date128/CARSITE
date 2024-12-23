using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ICarImageService
    {
        Task<List<CarImage>> GetAll();
        Task<CarImage> GetById(int id);
        Task Create(CarImage model);
        Task Update(CarImage model);
        Task Delete(int id);
    }
}