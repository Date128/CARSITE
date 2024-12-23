using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestDrivesController : ControllerBase
    {
        private readonly ITestDriveService _testDriveService;

        public TestDrivesController(ITestDriveService testDriveService)
        {
            _testDriveService = testDriveService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _testDriveService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _testDriveService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(TestDrife testDrive)
        {
            await _testDriveService.Create(testDrive);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(TestDrife testDrive)
        {
            await _testDriveService.Update(testDrive);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _testDriveService.Delete(id);
            return Ok();
        }
    }
}