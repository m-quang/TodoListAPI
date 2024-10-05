using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ToDoListAPI.Models
{
    public class Comment
    {
        [Key]
        public string Id { get; set; }
        public string TaskId { get; set; }
        public string ProjectId { get; set; }
        public string PostedAt { get; set; }
        [StringLength(2000)]
        public string Content { get; set; }
        public ICollection<Attachment>? Attachments { get; set; }
    }

    public class Attachment
    {
        [Key]
        public string Id { get; set; }
        public string FileName { get; set; }
        public string FileType { get; set; }
        public string FileUrl { get; set; }
        public string ResourceType { get; set; }
        public Comment Comment { get; set; }
    }
}
