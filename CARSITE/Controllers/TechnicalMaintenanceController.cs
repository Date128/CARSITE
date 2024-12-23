using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TechnicalMaintenanceController : ControllerBase
    {
        private readonly ITechnicalMaintenanceService _technicalMaintenanceService;

        public TechnicalMaintenanceController(ITechnicalMaintenanceService technicalMaintenanceService)
        {
            _technicalMaintenanceService = technicalMaintenanceService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _technicalMaintenanceService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _technicalMaintenanceService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(TechnicalMaintenance technicalMaintenance)
        {
            await _technicalMaintenanceService.Create(technicalMaintenance);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(TechnicalMaintenance technicalMaintenance)
        {
            await _technicalMaintenanceService.Update(technicalMaintenance);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _technicalMaintenanceService.Delete(id);
            return Ok();
        }
    }
}