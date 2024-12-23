using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RatingsController : ControllerBase
    {
        private readonly IRatingService _ratingService;

        public RatingsController(IRatingService ratingService)
        {
            _ratingService = ratingService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _ratingService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _ratingService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Rating rating)
        {
            await _ratingService.Create(rating);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Rating rating)
        {
            await _ratingService.Update(rating);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _ratingService.Delete(id);
            return Ok();
        }
    }
}