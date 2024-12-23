using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarsController : ControllerBase
    {
        private readonly ICarServices _carService;

        public CarsController(ICarServices carService)
        {
            _carService = carService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _carService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _carService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Car car)
        {
            await _carService.Create(car);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Car car)
        {
            await _carService.Update(car);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carService.Delete(id);
            return Ok();
        }
    }
}