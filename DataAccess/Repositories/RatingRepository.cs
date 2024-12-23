using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class RatingRepository : RepositoryBase<Rating>, IRatingRepository
    {
        public RatingRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}