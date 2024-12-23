using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpertRecommendationsController : ControllerBase
    {
        private readonly IExpertRecommendationService _expertRecommendationService;

        public ExpertRecommendationsController(IExpertRecommendationService expertRecommendationService)
        {
            _expertRecommendationService = expertRecommendationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _expertRecommendationService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _expertRecommendationService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(ExpertRecommendation expertRecommendation)
        {
            await _expertRecommendationService.Create(expertRecommendation);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(ExpertRecommendation expertRecommendation)
        {
            await _expertRecommendationService.Update(expertRecommendation);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _expertRecommendationService.Delete(id);
            return Ok();
        }
    }
}