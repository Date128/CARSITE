using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ServiceCentersController : ControllerBase
    {
        private readonly IServiceCenterService _serviceCenterService;

        public ServiceCentersController(IServiceCenterService serviceCenterService)
        {
            _serviceCenterService = serviceCenterService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _serviceCenterService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _serviceCenterService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ServiceCenter serviceCenter)
        {
            await _serviceCenterService.Create(serviceCenter);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ServiceCenter serviceCenter)
        {
            await _serviceCenterService.Update(serviceCenter);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _serviceCenterService.Delete(id);
            return Ok();
        }
    }
}