using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;

namespace HNGInternshipAssignment01.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HNGInternsController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetInfo()
        {
            var info = new
            {
                email = "Kelvinintech399@gmail.com",
                current_datetime = DateTime.UtcNow.ToString("o"),
                github_url = "https://github.com/0815Kelvin/HNGInternship-Ass0"
            };
            return Ok(info);
        }
    }
}
