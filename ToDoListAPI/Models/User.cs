using System.ComponentModel.DataAnnotations;

namespace ToDoListAPI.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        public string Email { get; set; }
        public string FullName { get; set;}
        public string JointedAt { get; set; }
        public string Token { get; set; }
    }
}
