﻿using Domain.Interfaces;
using Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CARSITEAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _notificationService.GetAll());
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            return Ok(await _notificationService.GetById(id));
        }

        [HttpPost]
        public async Task<IActionResult> Add(Notification notification)
        {
            await _notificationService.Create(notification);
            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update(Notification notification)
        {
            await _notificationService.Update(notification);
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _notificationService.Delete(id);
            return Ok();
        }
    }
}