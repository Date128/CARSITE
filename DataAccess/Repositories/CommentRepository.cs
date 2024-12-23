using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class CommentRepository : RepositoryBase<Comment>, ICommentRepository
    {
        public CommentRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}