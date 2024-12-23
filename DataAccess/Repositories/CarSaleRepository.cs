using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class CarSaleRepository : RepositoryBase<CarSale>, ICarSaleRepository
    {
        public CarSaleRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}