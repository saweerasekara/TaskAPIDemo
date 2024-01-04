using Microsoft.AspNetCore.Mvc;

namespace TaskAPI.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class TaksController : ControllerBase
    {
        [HttpGet]
        public IActionResult Tasks()
        {
            var task =  new string[] { "Task1", "Task2", "Task3", "Task4" };
            return Ok(task);
        }

        [HttpPost]
        public IActionResult NewTask()
        {
            return Ok();
        }

        [HttpPut]
        public IActionResult UpdateTask()
        {
            return Ok();
        }

        [HttpDelete]
        public IActionResult DeleteTask()
        {
            return Ok();
        }
    }
}
