using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models
{
    public class Label
    {
        [Key]
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Order { get; set; }
        public bool IsFavorite { get; set; }
    }
}
