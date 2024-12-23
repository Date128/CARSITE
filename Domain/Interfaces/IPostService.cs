using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IPostService
    {
        Task<List<Post>> GetAll();
        Task<Post> GetById(int id);
        Task Create(Post model);
        Task Update(Post model);
        Task Delete(int id);
    }
}