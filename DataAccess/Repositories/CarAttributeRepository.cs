using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class CarAttributeRepository : RepositoryBase<CarAttribute>, ICarAttributeRepository
    {
        public CarAttributeRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}