using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class TechnicalMaintenanceService : ITechnicalMaintenanceService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TechnicalMaintenanceService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<TechnicalMaintenance>> GetAll()
        {
            return await _repositoryWrapper.TechnicalMaintenance.FindAll();
        }

        public async Task<TechnicalMaintenance> GetById(int id)
        {
            var technicalMaintenance = await _repositoryWrapper.TechnicalMaintenance
                .FindByCondition(x => x.MaintenanceId == id);
            return technicalMaintenance.First();
        }

        public async Task Create(TechnicalMaintenance model)
        {
            await _repositoryWrapper.TechnicalMaintenance.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(TechnicalMaintenance model)
        {
            _repositoryWrapper.TechnicalMaintenance.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var technicalMaintenance = await _repositoryWrapper.TechnicalMaintenance
                .FindByCondition(x => x.MaintenanceId == id);

            _repositoryWrapper.TechnicalMaintenance.Delete(technicalMaintenance.First());
            _repositoryWrapper.Save();
        }
    }
}