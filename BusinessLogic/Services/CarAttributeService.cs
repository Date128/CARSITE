using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper;
using System;

namespace BusinessLogic.Services
{
    public class CarAttributeService : ICarAttributeService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public CarAttributeService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<CarAttribute>> GetAll()
        {
            return await _repositoryWrapper.CarAttribute.FindAll();
        }

        public async Task<CarAttribute> GetById(int carId, int attributeId)
        {
            var carAttribute = await _repositoryWrapper.CarAttribute
                .FindByCondition(x => x.CarId == carId && x.AttributeId == attributeId);
            return carAttribute.First();
        }

        public async Task Create(CarAttribute model)
        {
            await _repositoryWrapper.CarAttribute.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(CarAttribute model)
        {
            _repositoryWrapper.CarAttribute.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int carId, int attributeId)
        {
            var carAttribute = await _repositoryWrapper.CarAttribute
                .FindByCondition(x => x.CarId == carId && x.AttributeId == attributeId);

            _repositoryWrapper.CarAttribute.Delete(carAttribute.First());
            _repositoryWrapper.Save();
        }
    }
}