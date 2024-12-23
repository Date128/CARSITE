using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class CarRentalRepository : RepositoryBase<CarRental>, ICarRentalRepository
    {
        public CarRentalRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}