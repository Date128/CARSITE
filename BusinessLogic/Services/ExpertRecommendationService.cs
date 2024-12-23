using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class ExpertRecommendationService : IExpertRecommendationService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ExpertRecommendationService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<ExpertRecommendation>> GetAll()
        {
            return await _repositoryWrapper.ExpertRecommendation.FindAll();
        }

        public async Task<ExpertRecommendation> GetById(int id)
        {
            var expertRecommendation = await _repositoryWrapper.ExpertRecommendation
                .FindByCondition(x => x.RecommendationId == id);
            return expertRecommendation.First();
        }

        public async Task Create(ExpertRecommendation model)
        {
            await _repositoryWrapper.ExpertRecommendation.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(ExpertRecommendation model)
        {
            _repositoryWrapper.ExpertRecommendation.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var expertRecommendation = await _repositoryWrapper.ExpertRecommendation
                .FindByCondition(x => x.RecommendationId == id);

            _repositoryWrapper.ExpertRecommendation.Delete(expertRecommendation.First());
            _repositoryWrapper.Save();
        }
    }
}