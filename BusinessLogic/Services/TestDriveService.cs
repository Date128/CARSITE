using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class TestDriveService : ITestDriveService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public TestDriveService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<TestDrife>> GetAll()
        {
            return await _repositoryWrapper.TestDrife.FindAll();
        }

        public async Task<TestDrife> GetById(int id)
        {
            var testDrife = await _repositoryWrapper.TestDrife
                .FindByCondition(x => x.TestDriveId == id);
            return testDrife.First();
        }

        public async Task Create(TestDrife model)
        {
            await _repositoryWrapper.TestDrife.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(TestDrife model)
        {
            _repositoryWrapper.TestDrife.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var testDrife = await _repositoryWrapper.TestDrife
                .FindByCondition(x => x.TestDriveId == id);

            _repositoryWrapper.TestDrife.Delete(testDrife.First());
            _repositoryWrapper.Save();
        }
    }
}