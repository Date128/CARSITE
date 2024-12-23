using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;

namespace Domain.Interfaces
{
    public interface ICarServices
    {
        Task<List<Car>> GetAll();
        Task<Car> GetById(int id);
        Task Create(Car model);
        Task Update(Car model);
        Task Delete(int id);
    }
}
