using Domain.Interfaces;
using Domain.Models;
namespace DataAccess.Repositories
{
   
        public class CarRepository : RepositoryBase<Car>, ICarRepository
        {
            public CarRepository(CarsiteContext repositoryContext) : base(repositoryContext)
            {

            }
        }
}
