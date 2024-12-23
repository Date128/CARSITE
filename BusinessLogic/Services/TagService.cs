using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class TagService : ITagService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TagService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Tag>> GetAll()
        {
            return await _repositoryWrapper.Tag.FindAll();
        }

        public async Task<Tag> GetById(int id)
        {
            var tag = await _repositoryWrapper.Tag
                .FindByCondition(x => x.TagId == id);
            return tag.First();
        }

        public async Task Create(Tag model)
        {
            await _repositoryWrapper.Tag.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Tag model)
        {
            _repositoryWrapper.Tag.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var tag = await _repositoryWrapper.Tag
                .FindByCondition(x => x.TagId == id);

            _repositoryWrapper.Tag.Delete(tag.First());
            _repositoryWrapper.Save();
        }
    }
}