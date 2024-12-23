using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class PostService : IPostService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public PostService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Post>> GetAll()
        {
            return await _repositoryWrapper.Post.FindAll();
        }

        public async Task<Post> GetById(int id)
        {
            var post = await _repositoryWrapper.Post
                .FindByCondition(x => x.PostId == id);
            return post.First();
        }

        public async Task Create(Post model)
        {
            await _repositoryWrapper.Post.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Post model)
        {
            _repositoryWrapper.Post.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var post = await _repositoryWrapper.Post
                .FindByCondition(x => x.PostId == id);

            _repositoryWrapper.Post.Delete(post.First());
            _repositoryWrapper.Save();
        }
    }
}