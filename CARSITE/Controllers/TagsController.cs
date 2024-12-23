using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TagsController : ControllerBase
    {
        private readonly ITagService _tagService;

        public TagsController(ITagService tagService)
        {
            _tagService = tagService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _tagService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _tagService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Tag tag)
        {
            await _tagService.Create(tag);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Tag tag)
        {
            await _tagService.Update(tag);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _tagService.Delete(id);
            return Ok();
        }
    }
}