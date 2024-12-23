using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class UserProfileService : IUserProfileService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public UserProfileService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<UserProfile>> GetAll()
        {
            return await _repositoryWrapper.UserProfile.FindAll();
        }

        public async Task<UserProfile> GetById(int id)
        {
            var userProfile = await _repositoryWrapper.UserProfile
                .FindByCondition(x => x.ProfileId == id);
            return userProfile.First();
        }

        public async Task Create(UserProfile model)
        {
            await _repositoryWrapper.UserProfile.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(UserProfile model)
        {
            _repositoryWrapper.UserProfile.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var userProfile = await _repositoryWrapper.UserProfile
                .FindByCondition(x => x.ProfileId == id);

            _repositoryWrapper.UserProfile.Delete(userProfile.First());
            _repositoryWrapper.Save();
        }
    }
}