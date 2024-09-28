using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using ToDoListAPI.Services;

namespace ToDoListAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TasksController : Controller
    {
        private readonly ITaskService _taskService;

        public TasksController(ITaskService taskService)
        {
            _taskService = taskService;
        }

        [HttpGet]
        public async Task<IActionResult> GetActiveTasks(string taksID)
        {
            return new StatusCodeResult(StatusCodes.Status200OK);
        }

        [HttpPost]
        public async Task<IActionResult> CreateTask(DTOs.Task task)
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

            return CreatedAtAction(nameof(CreateTask), new { id = createdTask.Id }, createdTask);
        }

        [HttpPost("{id}")]
        public async Task<IActionResult> UpdateTask(DTOs.Task task)
        {
            return CreatedAtAction(nameof(UpdateTask), new { id = "1" });
        }

        [HttpPost("{id}/Close")]
        public async Task<IActionResult> CloseTask(DTOs.Task task)
        {
            return Ok();
        }

        [HttpPost("{id}/Reopen")]
        public async Task<IActionResult> ReopenTask(DTOs.Task task)
        {
            return Ok();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTask(DTOs.Task task)
        {
            return Ok();
        }
    }
}
