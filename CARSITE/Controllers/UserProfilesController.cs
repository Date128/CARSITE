using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;

namespace BackendApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserProfilesController : ControllerBase
    {
        private readonly IUserProfileService _userProfileService;

        public UserProfilesController(IUserProfileService userProfileService)
        {
            _userProfileService = userProfileService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userProfileService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _userProfileService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(UserProfile userProfile)
        {
            await _userProfileService.Create(userProfile);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(UserProfile userProfile)
        {
            await _userProfileService.Update(userProfile);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _userProfileService.Delete(id);
            return Ok();
        }
    }
}