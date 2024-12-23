using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPostTagService
    {
        Task<List<PostTag>> GetAll();
        Task<PostTag> GetById(int id);
        Task Create(PostTag model);
        Task Update(PostTag model);
        Task Delete(int id);
    }
}