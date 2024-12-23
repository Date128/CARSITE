using System.Collections.Generic;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface IExpertRecommendationService
    {
        Task<List<ExpertRecommendation>> GetAll();
        Task<ExpertRecommendation> GetById(int id);
        Task Create(ExpertRecommendation model);
        Task Update(ExpertRecommendation model);
        Task Delete(int id);
    }
}