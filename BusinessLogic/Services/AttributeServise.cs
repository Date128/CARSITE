using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using MyAttribute = Domain.Models.Attribute;

namespace BusinessLogic.Services
{
    public class AttributeServise : IAttributeServise
    {
        private IRepositoryWrapper _repositoryWrapper;

        public AttributeServise(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<MyAttribute>> GetAll()
        {
            return await _repositoryWrapper.Attribute.FindAll();
        }

        public async Task<MyAttribute> GetById(int id)
        {
            var attribute = await _repositoryWrapper.Attribute
                .FindByCondition(x => x.AttributeId == id);
            return attribute.First();
        }

        public async Task Create(MyAttribute model)
        {
            await _repositoryWrapper.Attribute.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(MyAttribute model)
        {
            _repositoryWrapper.Attribute.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var attribute = await _repositoryWrapper.Attribute
                .FindByCondition(x => x.AttributeId == id);

            _repositoryWrapper.Attribute.Delete(attribute.First());
            _repositoryWrapper.Save();
        }
    }
}