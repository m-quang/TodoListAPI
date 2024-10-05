using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models
{
    public class Task
    {
        [Key]
        public string Id { get; set; }
        public string ProjectId { get; set; }
        public string Content { get; set; }
        public string Description { get; set; }
        public string CreatedAt { get; set; }
        public string CreatorId { get; set; }
        public Due? Due { get; set; }
        public int Priority { get; set; }
        public int Order { get; set; }
        public bool IsCompleted { get; set; }
        public string SectionId { get; set; }
        public string[] Labels { get; set; }
        public string ParentId { get; set; }
        public string Url { get; set; }
        public string CommentCount { get; set; }
        public string AssigneeId { get; set; }
        public string AssignerId { get; set; }
        public Duration? Duration { get; set; }
    }

    public class Due
    {
        [Key]
        public string Id { get; set; }
        public string String { get; set; }
        public string Date { get; set; }
        public bool IsRecurring { get; set; }
        public string Datetime { get; set; }
        public string TimeZone { get; set; }
        public Task Task { get; set; }
    }

    public class Duration
    {
        [Key]
        public string Id { get; set; }
        public uint Amount { get; set; }
        public string Unit { get; set; }
        public Task Task { get; set; }

    }
}
