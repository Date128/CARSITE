using Domain.Interfaces;
using Domain.Models;
using Domain.Wrapper; 

namespace BusinessLogic.Services
{
    public class CarImageService : ICarImageService
    {
        private IRepositoryWrapper _repositoryWrapper;

        public CarImageService(IRepositoryWrapper repositoryWrapper)
        {
            _repositoryWrapper = repositoryWrapper;
        }

        public async Task<List<CarImage>> GetAll()
        {
            return await _repositoryWrapper.CarImage.FindAll();
        }

        public async Task<CarImage> GetById(int id)
        {
            var carImage = await _repositoryWrapper.CarImage
                .FindByCondition(x => x.ImageId == id);
            return carImage.First();
        }

        public async Task Create(CarImage model)
        {
            await _repositoryWrapper.CarImage.Create(model);
            _repositoryWrapper.Save();
        }

        public async Task Update(CarImage model)
        {
            _repositoryWrapper.CarImage.Update(model);
            _repositoryWrapper.Save();
        }

        public async Task Delete(int id)
        {
            var carImage = await _repositoryWrapper.CarImage
                .FindByCondition(x => x.ImageId == id);

            _repositoryWrapper.CarImage.Delete(carImage.First());
            _repositoryWrapper.Save();
        }
    }
}