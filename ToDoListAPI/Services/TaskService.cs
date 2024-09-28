namespace ToDoListAPI.Services
{
    public class TaskService : ITaskService
    {
        //private readonly YourDbContext _context;

        //public TaskService(YourDbContext context)
        //{
        //    _context = context;
        //}

        public async Task<DTOs.Task> AddTaskAsync(DTOs.Task taskDto)
        {
            var newTask = new DTOs.Task
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

            //_context.Tasks.Add(newTask);
            //await _context.SaveChangesAsync();

            return newTask;
        }
    }
}