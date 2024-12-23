using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class CarImageRepository : RepositoryBase<CarImage>, ICarImageRepository
    {
        public CarImageRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}