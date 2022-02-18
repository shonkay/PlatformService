using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlatformService.DTOs;
using PlatformService.Services;
using System;
using System.Threading.Tasks;

namespace PlatformService.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PlatformController : ControllerBase
    {
        private readonly PlatformServices _platform;

        public PlatformController(PlatformServices platform)
        {
            _platform = platform;
        }

        [HttpGet]
        public async Task<IActionResult> GetPlatforms()
        {
            try
            {
                var result = await _platform.GetAllPlatform();
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
