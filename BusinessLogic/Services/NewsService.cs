using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class NewsService : INewsService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public NewsService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<News>> GetAll()
        {
            return await _repositoryWrapper.News.FindAll();
        }

        public async Task<News> GetById(int id)
        {
            var news = await _repositoryWrapper.News
                .FindByCondition(x => x.NewsId == id);
            return news.First();
        }

        public async Task Create(News model)
        {
            await _repositoryWrapper.News.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(News model)
        {
            _repositoryWrapper.News.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var news = await _repositoryWrapper.News
                .FindByCondition(x => x.NewsId == id);

            _repositoryWrapper.News.Delete(news.First());
            _repositoryWrapper.Save();
        }
    }
}