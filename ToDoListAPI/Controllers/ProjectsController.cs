using Microsoft.AspNetCore.Mvc;

namespace ToDoListAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProjectsController
    {
        [HttpGet]
        public async Task<IActionResult> GetActiveTasks(string taksID)
        {
            return new StatusCodeResult(StatusCodes.Status200OK);
        }


    }
}
