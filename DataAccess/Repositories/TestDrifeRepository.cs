using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class TestDrifeRepository : RepositoryBase<TestDrife>, ITestDrifeRepository
    {
        public TestDrifeRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}