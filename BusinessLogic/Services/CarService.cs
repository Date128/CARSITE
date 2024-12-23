using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class CarService : ICarServices
    {
        private IRepositoryWrapper _repositoryWrapper;

        public CarService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<Car>> GetAll()
        {
            return await _repositoryWrapper.Car.FindAll();
        }

        public async Task<Car> GetById(int id)
        {
            var car = await _repositoryWrapper.Car
                .FindByCondition(x => x.CarId == id);
            return car.First();
        }

        public async Task Create(Car model)
        {
            await _repositoryWrapper.Car.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(Car model)
        {
            _repositoryWrapper.Car.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var car = await _repositoryWrapper.CarSale
                .FindByCondition(x => x.CarId == id);

            _repositoryWrapper.CarSale.Delete(car.First());
            _repositoryWrapper.Save();
        }
    }
}