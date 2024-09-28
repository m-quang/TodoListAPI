namespace ToDoListAPI.DTOs
{
    public class Label
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Color { get; set; }
        public int Order { get; set; }
        public bool IsFavorite { get; set; }
    }
}
