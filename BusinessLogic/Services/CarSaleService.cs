using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;

namespace BusinessLogic.Services
{
    public class CarSaleService : ICarSaleService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public CarSaleService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<CarSale>> GetAll()
        {
            return await _repositoryWrapper.CarSale.FindAll();
        }

        public async Task<CarSale> GetById(int id)
        {
            var user = await _repositoryWrapper.CarSale
                .FindByCondition(x => x.SaleId == id);
            return user.First();
        }

        public async Task Create(CarSale model)
        {
            await _repositoryWrapper.CarSale.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(CarSale model)
        {
            _repositoryWrapper.CarSale.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var carSale = await _repositoryWrapper.CarSale
                .FindByCondition(x => x.SaleId == id);

            _repositoryWrapper.CarSale.Delete(carSale.First());
            _repositoryWrapper.Save();
        }
    }
}