using Domain.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Domain.Interfaces
{
    public interface ITestDriveService
    {
        Task<List<TestDrife>> GetAll();
        Task<TestDrife> GetById(int id);
        Task Create(TestDrife model);
        Task Update(TestDrife model);
        Task Delete(int id);
    }
}