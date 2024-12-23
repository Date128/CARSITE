using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class MaintenanceRecordService : IMaintenanceRecordService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public MaintenanceRecordService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<MaintenanceRecord>> GetAll()
        {
            return await _repositoryWrapper.MaintenanceRecord.FindAll();
        }

        public async Task<MaintenanceRecord> GetById(int id)
        {
            var maintenanceRecord = await _repositoryWrapper.MaintenanceRecord
                .FindByCondition(x => x.RecordId == id);
            return maintenanceRecord.First();
        }

        public async Task Create(MaintenanceRecord model)
        {
            await _repositoryWrapper.MaintenanceRecord.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(MaintenanceRecord model)
        {
            _repositoryWrapper.MaintenanceRecord.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var maintenanceRecord = await _repositoryWrapper.MaintenanceRecord
                .FindByCondition(x => x.RecordId == id);

            _repositoryWrapper.MaintenanceRecord.Delete(maintenanceRecord.First());
            _repositoryWrapper.Save();
        }
    }
}