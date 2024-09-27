namespace ToDoListAPI.Services
{
    public interface ITaskService
    {
        Task<DTOs.Task> AddTaskAsync(DTOs.Task task);
    }
}
