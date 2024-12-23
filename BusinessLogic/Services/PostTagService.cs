using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class PostTagService : IPostTagService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public PostTagService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<PostTag>> GetAll()
        {
            return await _repositoryWrapper.PostTag.FindAll();
        }

        public async Task<PostTag> GetById(int id)
        {
            var postTag = await _repositoryWrapper.PostTag
                .FindByCondition(x => x.PostTagId == id);
            return postTag.First();
        }

        public async Task Create(PostTag model)
        {
            await _repositoryWrapper.PostTag.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(PostTag model)
        {
            _repositoryWrapper.PostTag.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var postTag = await _repositoryWrapper.PostTag
                .FindByCondition(x => x.PostTagId == id);

            _repositoryWrapper.PostTag.Delete(postTag.First());
            _repositoryWrapper.Save();
        }
    }
}