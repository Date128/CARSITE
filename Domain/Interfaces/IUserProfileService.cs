using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface IUserProfileService
    {
        Task<List<UserProfile>> GetAll();
        Task<UserProfile> GetById(int id);
        Task Create(UserProfile model);
        Task Update(UserProfile model);
        Task Delete(int id);
    }
}