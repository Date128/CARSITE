using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class PostRepository : RepositoryBase<Post>, IPostRepository
    {
        public PostRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}