using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class UserProfileRepository : RepositoryBase<UserProfile>, IUserProfileRepository
    {
        public UserProfileRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}