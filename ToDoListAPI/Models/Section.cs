using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models
{
    public class Section
    {
        [Key]
        public string Id { get; set; }
        public string ProjectId { get; set; }
        public int Order { get; set; }
        public string Name { get; set; }
    }
}
