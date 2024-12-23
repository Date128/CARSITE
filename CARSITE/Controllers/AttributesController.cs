using Domain.Interfaces;
using BusinessLogic.Services;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using MyAttribute = Domain.Models.Attribute;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AttributesController : ControllerBase
    {
        private readonly IAttributeServise _attributeService;

        public AttributesController(IAttributeServise attributeService)
        {
            _attributeService = attributeService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _attributeService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _attributeService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(MyAttribute attribute)
        {
            await _attributeService.Create(attribute);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(MyAttribute attribute)
        {
            await _attributeService.Update(attribute);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _attributeService.Delete(id);
            return Ok();
        }
    }
}