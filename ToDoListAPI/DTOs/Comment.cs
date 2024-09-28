namespace ToDoListAPI.DTOs
{
    public class Comment
    {
        public int Id { get; set; }
        public string TaskId { get; set; }
        public string ProjectId { get; set; }
        public string PostedAt { get; set; }
        public string Content { get; set; }
        public Object Attackment { get; set; }
    }

    public class Attackment
    {
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public string ResourceType { get; set; }
    }
}
