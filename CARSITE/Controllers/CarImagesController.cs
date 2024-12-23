using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CarImagesController : ControllerBase
    {
        private readonly ICarImageService _carImageService;

        public CarImagesController(ICarImageService carImageService)
        {
            _carImageService = carImageService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _carImageService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _carImageService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(CarImage carImage)
        {
            await _carImageService.Create(carImage);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(CarImage carImage)
        {
            await _carImageService.Update(carImage);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _carImageService.Delete(id);
            return Ok();
        }
    }
}