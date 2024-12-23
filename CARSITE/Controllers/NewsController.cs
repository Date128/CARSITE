using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NewsController : ControllerBase
    {
        private readonly INewsService _newsService;

        public NewsController(INewsService newsService)
        {
            _newsService = newsService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _newsService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _newsService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(News news)
        {
            await _newsService.Create(news);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(News news)
        {
            await _newsService.Update(news);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _newsService.Delete(id);
            return Ok();
        }
    }
}