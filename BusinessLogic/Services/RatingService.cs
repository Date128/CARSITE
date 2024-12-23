using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class RatingService : IRatingService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public RatingService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Rating>> GetAll()
        {
            return await _repositoryWrapper.Rating.FindAll();
        }

        public async Task<Rating> GetById(int id)
        {
            var rating = await _repositoryWrapper.Rating
                .FindByCondition(x => x.RatingId == id);
            return rating.First();
        }

        public async Task Create(Rating model)
        {
            await _repositoryWrapper.Rating.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Rating model)
        {
            _repositoryWrapper.Rating.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var rating = await _repositoryWrapper.Rating
                .FindByCondition(x => x.RatingId == id);

            _repositoryWrapper.Rating.Delete(rating.First());
            _repositoryWrapper.Save();
        }
    }
}