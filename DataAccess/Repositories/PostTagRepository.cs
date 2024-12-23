using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class PostTagRepository : RepositoryBase<PostTag>, IPostTagRepository
    {
        public PostTagRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}