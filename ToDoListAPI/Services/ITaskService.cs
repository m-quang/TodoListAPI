using Microsoft.EntityFrameworkCore;

namespace ToDoListAPI.Services
{
    public interface ITaskService
    {
        Task<Models.Task> AddTaskAsync(Models.Task task);
    }
}
