using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarSalesController : ControllerBase
    {
        private readonly ICarSaleService _carSaleService;

        public CarSalesController(ICarSaleService carSaleService)
        {
            _carSaleService = carSaleService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _carSaleService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _carSaleService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarSale carSale)
        {
            await _carSaleService.Create(carSale);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CarSale carSale)
        {
            await _carSaleService.Update(carSale);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carSaleService.Delete(id);
            return Ok();
        }
    }
}