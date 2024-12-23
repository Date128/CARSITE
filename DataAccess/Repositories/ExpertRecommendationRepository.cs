using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class ExpertRecommendationRepository : RepositoryBase<ExpertRecommendation>, IExpertRecommendationRepository
    {
        public ExpertRecommendationRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}