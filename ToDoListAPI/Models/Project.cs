using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models
{
    public class Project
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public string ParentId { get; set; }
        public int Order { get; set; }
        public int CommentCount { get; set; }
        public bool IsShare {  get; set; }
        public bool IsFavourite { get; set; }
        public bool IsInboxProject { get; set; }
        public bool IsTeamInbox {  get; set; }
        public string ViewStyle { get; set; }
        public string Url { get; set; }
    }
}
