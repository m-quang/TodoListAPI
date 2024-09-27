namespace ToDoListAPI.DTOs
{
    public class Task
    {
        public string Id { get; set; }
        public string ProjectID { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public DateTime CreateAt { get; set; }
        public DateTime Due { get; set; }
        public int Priority { get; set; }
        public int Order { get; set; }
        public bool IsCompleted { get; set; }
    }
}
