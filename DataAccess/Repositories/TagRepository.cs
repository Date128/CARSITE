using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    internal class TagRepository : RepositoryBase<Tag>, ITagRepository
    {
        public TagRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {

        }
    }
}
