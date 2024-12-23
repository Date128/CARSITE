using Domain.Interfaces;
using Domain.Models;

namespace DataAccess.Repositories
{
    public class AttributeRepository : RepositoryBase<Domain.Models.Attribute>,  IAttributeRepository
    {
        public AttributeRepository(CarsiteContext repositoryContext) : base(repositoryContext)
        {
        }
    }
}