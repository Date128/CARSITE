using Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MyAttribute = Domain.Models.Attribute;

namespace Domain.Interfaces
{
    public interface IAttributeServise
    {
        Task<List<MyAttribute>> GetAll();
        Task<MyAttribute> GetById(int id);
        Task Create(MyAttribute model);
        Task Update(MyAttribute model);
        Task Delete(int id);
    }
}
