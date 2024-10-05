using Microsoft.EntityFrameworkCore;

namespace ToDoListAPI.Services
{
    public class TaskService : ITaskService
    {
        private readonly TodoListContext _context;

        public TaskService(TodoListContext context)
        {
            _context = context;
        }

        public async Task<Models.Task> AddTaskAsync(Models.Task taskDto)
        {
            var newTask = new Models.Task
            {
                Id = taskDto.Id,
                ProjectId = taskDto.ProjectId,
                Content = taskDto.Content,
                Description = taskDto.Description,
                CreatedAt = taskDto.CreatedAt,
                Due = taskDto.Due,
                Priority = taskDto.Priority,
                Order = taskDto.Order,
                IsCompleted = taskDto.IsCompleted
            };

            _context.Tasks.Add(newTask);
            await _context.SaveChangesAsync();

            return newTask;
        }
    }
}