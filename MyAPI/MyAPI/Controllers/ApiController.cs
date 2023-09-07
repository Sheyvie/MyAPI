using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using MyAPI.Model;

namespace MyAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ApiController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string slack_name, string track)
        {
            // Create an instance of the ApiResponse
            var response = new ApiResponse
            {
                SlackName = slack_name,
                CurrentDay = DateTime.UtcNow.ToString("dddd"),
                UtcTime = DateTime.UtcNow,
                Track = track,
                GitHubFileUrl = "https://github.com/username/repo/blob/main/file_name.ext",
                GitHubRepoUrl = "https://github.com/Sheyvie/MyAPI.git"
            };

            return Ok(response);
        }
    }
}
