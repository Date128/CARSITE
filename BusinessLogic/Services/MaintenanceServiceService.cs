using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class MaintenanceServiceService : IMaintenanceServiceService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MaintenanceServiceService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<MaintenanceService>> GetAll()
        {
            return await _repositoryWrapper.MaintenanceService.FindAll();
        }

        public async Task<MaintenanceService> GetById(int id)
        {
            var maintenanceService = await _repositoryWrapper.MaintenanceService
                .FindByCondition(x => x.ServiceId == id);
            return maintenanceService.First();
        }

        public async Task Create(MaintenanceService model)
        {
            await _repositoryWrapper.MaintenanceService.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(MaintenanceService model)
        {
            _repositoryWrapper.MaintenanceService.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var maintenanceService = await _repositoryWrapper.MaintenanceService
                .FindByCondition(x => x.ServiceId == id);

            _repositoryWrapper.MaintenanceService.Delete(maintenanceService.First());
            _repositoryWrapper.Save();
        }
    }
}