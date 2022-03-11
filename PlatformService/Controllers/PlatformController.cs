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

        [HttpGet("[action]")]
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

        [HttpGet("[action]/{Id}")]
        public async Task<IActionResult> GetPlatform(Guid Id)
        {
            try
            {
                var result = await _platform.GetByPlatformId(Id);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost("[action]")]
        public async Task<IActionResult> CreatePlatforms(CreatePlatformDTO platformDTO)
        {
            try
            {
                var result = await _platform.CreatePlatform(platformDTO);
                return Ok(result);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
