using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class ReviewRepository : RepositoryBase<Review>, IReviewRepository
    {
        public ReviewRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}