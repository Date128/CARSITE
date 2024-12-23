using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class CarRentalService : ICarRentalService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public CarRentalService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<CarRental>> GetAll()
        {
            return await _repositoryWrapper.CarRental.FindAll();
        }

        public async Task<CarRental> GetById(int id)
        {
            var carRental = await _repositoryWrapper.CarRental
                .FindByCondition(x => x.RentalId == id);
            return carRental.First();
        }

        public async Task Create(CarRental model)
        {
            await _repositoryWrapper.CarRental.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(CarRental model)
        {
            _repositoryWrapper.CarRental.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var carRental = await _repositoryWrapper.CarRental
                .FindByCondition(x => x.RentalId == id);

            _repositoryWrapper.CarRental.Delete(carRental.First());
            _repositoryWrapper.Save();
        }
    }
}