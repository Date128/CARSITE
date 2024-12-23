using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarAttributesController : ControllerBase
    {
        private readonly ICarAttributeService _carAttributeService;

        public CarAttributesController(ICarAttributeService carAttributeService)
        {
            _carAttributeService = carAttributeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _carAttributeService.GetAll());
        }

        [HttpGet("{carId}/{attributeId}")]
        public async Task<IActionResult> GetById(int carId, int attributeId)
        {
            return Ok(await _carAttributeService.GetById(carId, attributeId));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarAttribute carAttribute)
        {
            await _carAttributeService.Create(carAttribute);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CarAttribute carAttribute)
        {
            await _carAttributeService.Update(carAttribute);
            return Ok();
        }

        [HttpDelete("{carId}/{attributeId}")]
        public async Task<IActionResult> Delete(int carId, int attributeId)
        {
            await _carAttributeService.Delete(carId, attributeId);
            return Ok();
        }
    }
}