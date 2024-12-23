using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarRentalsController : ControllerBase
    {
        private readonly ICarRentalService _carRentalService;

        public CarRentalsController(ICarRentalService carRentalService)
        {
            _carRentalService = carRentalService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _carRentalService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _carRentalService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarRental carRental)
        {
            await _carRentalService.Create(carRental);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CarRental carRental)
        {
            await _carRentalService.Update(carRental);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carRentalService.Delete(id);
            return Ok();
        }
    }
}