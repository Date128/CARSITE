using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostTagsController : ControllerBase
    {
        private readonly IPostTagService _postTagService;

        public PostTagsController(IPostTagService postTagService)
        {
            _postTagService = postTagService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _postTagService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _postTagService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(PostTag postTag)
        {
            await _postTagService.Create(postTag);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(PostTag postTag)
        {
            await _postTagService.Update(postTag);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _postTagService.Delete(id);
            return Ok();
        }
    }
}