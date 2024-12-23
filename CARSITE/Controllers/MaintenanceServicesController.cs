using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MaintenanceServicesController : ControllerBase
    {
        private readonly IMaintenanceServiceService _maintenanceServiceService;

        public MaintenanceServicesController(IMaintenanceServiceService maintenanceServiceService)
        {
            _maintenanceServiceService = maintenanceServiceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _maintenanceServiceService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _maintenanceServiceService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(MaintenanceService maintenanceService)
        {
            await _maintenanceServiceService.Create(maintenanceService);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(MaintenanceService maintenanceService)
        {
            await _maintenanceServiceService.Update(maintenanceService);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _maintenanceServiceService.Delete(id);
            return Ok();
        }
    }
}