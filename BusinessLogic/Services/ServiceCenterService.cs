using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class ServiceCenterService : IServiceCenterService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public ServiceCenterService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<ServiceCenter>> GetAll()
        {
            return await _repositoryWrapper.ServiceCenter.FindAll();
        }

        public async Task<ServiceCenter> GetById(int id)
        {
            var serviceCenter = await _repositoryWrapper.ServiceCenter
                .FindByCondition(x => x.CenterId == id);
            return serviceCenter.First();
        }

        public async Task Create(ServiceCenter model)
        {
            await _repositoryWrapper.ServiceCenter.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(ServiceCenter model)
        {
            _repositoryWrapper.ServiceCenter.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var serviceCenter = await _repositoryWrapper.ServiceCenter
                .FindByCondition(x => x.CenterId == id);

            _repositoryWrapper.ServiceCenter.Delete(serviceCenter.First());
            _repositoryWrapper.Save();
        }
    }
}