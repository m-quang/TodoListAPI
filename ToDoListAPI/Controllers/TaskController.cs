using Microsoft.AspNetCore.Mvc;
using ToDoListAPI.Services;

namespace ToDoListAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TaskController : Controller
    {
        private readonly ITaskService _taskService;

        public TaskController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpPost(Name = "tasks")]
        public async Task<IActionResult> AddTask(DTOs.Task task)
        {
            if (task == null || string.IsNullOrEmpty(task.Content))
            {
                return BadRequest("Task is invalid.");
            }

            var createdTask = await _taskService.AddTaskAsync(task);

            if (createdTask == null)
            {
                return StatusCode(500, "A problem occurred while handling your request.");
            }

            return CreatedAtAction(nameof(AddTask), new { id = createdTask.Id }, createdTask);
        }
    }
}
