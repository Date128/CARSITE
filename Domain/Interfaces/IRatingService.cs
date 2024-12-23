using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IRatingService
    {
        Task<List<Rating>> GetAll();
        Task<Rating> GetById(int id);
        Task Create(Rating model);
        Task Update(Rating model);
        Task Delete(int id);
    }
}