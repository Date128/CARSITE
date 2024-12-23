using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface INewsService
    {
        Task<List<News>> GetAll();
        Task<News> GetById(int id);
        Task Create(News model);
        Task Update(News model);
        Task Delete(int id);
    }
}