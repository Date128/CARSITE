using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class NewsRepository : RepositoryBase<News>, INewsRepository
    {
        public NewsRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}