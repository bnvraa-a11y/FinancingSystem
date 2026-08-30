using System.Security.Claims;
using FinancingSystem.API.DTOs;
using FinancingSystem.API.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace FinancingSystem.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Authorize]
    public class FinancingApplicationsController : ControllerBase
    {
        private readonly IFinancingApplicationService _service;

        public FinancingApplicationsController(IFinancingApplicationService service)
        {
            _service = service;
        }

        [HttpPost]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> Create([FromBody] CreateApplicationDto dto)
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var result = await _service.CreateAsync(userId, dto);
            return Ok(result);
        }

        [HttpGet("my-applications")]
        [Authorize(Roles = "User")]
        public async Task<IActionResult> GetMyApplications()
        {
            var userId = int.Parse(User.FindFirstValue(ClaimTypes.NameIdentifier)!);
            var result = await _service.GetMyApplicationsAsync(userId);
            return Ok(result);
        }

        [HttpGet]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> GetAll()
        {
            var result = await _service.GetAllApplicationsAsync();
            return Ok(result);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _service.GetByIdAsync(id);
            if (result == null) return NotFound();
            return Ok(result);
        }

        [HttpPut("{id}/review")]
        [Authorize(Roles = "Admin,Employee")]
        public async Task<IActionResult> Review(int id, [FromBody] ReviewApplicationDto dto)
        {
            try
            {
                var result = await _service.ReviewApplicationAsync(id, dto);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
    }
}