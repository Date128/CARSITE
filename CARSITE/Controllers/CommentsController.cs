using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace CARSITEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CommentsController : ControllerBase
    {
        private readonly ICommentService _commentService;

        public CommentsController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _commentService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _commentService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Comment comment)
        {
            await _commentService.Create(comment);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Comment comment)
        {
            await _commentService.Update(comment);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _commentService.Delete(id);
            return Ok();
        }
    }
}