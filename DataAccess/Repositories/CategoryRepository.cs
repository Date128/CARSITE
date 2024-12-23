using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class CategoryRepository : RepositoryBase<Category>, ICategoryRepository
    {
        public CategoryRepository(CarsiteContext repositoryContext) : base (repositoryContext)
        {

        }
    }
}
