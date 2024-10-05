using Microsoft.EntityFrameworkCore;

namespace ToDoListAPI
{
    using ToDoListAPI.Models;

    public class TodoListContext : DbContext
    {
        public TodoListContext(DbContextOptions<TodoListContext> options) : base(options) { }

        public DbSet<Comment> Comments { get; set; }
        public DbSet<Label> Labels { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Task> Tasks { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Attachment> Attachments { get; set; }
        public DbSet<Due> Dues { get; set; }
        public DbSet<Duration> Durations { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Comment>()
                .HasKey(c => c.Id);
            modelBuilder.Entity<Attachment>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Comment>()
                .HasMany(a => a.Attachments)
                .WithOne(c => c.Comment)
                .HasForeignKey("CommentId");

            modelBuilder.Entity<Task>()
                .HasKey(t => t.Id);
            modelBuilder.Entity<Due>()
                .HasKey(d => d.Id);
            modelBuilder.Entity<Duration>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Task>()
                .HasOne(d => d.Due)
                .WithOne(t => t.Task)
                .HasForeignKey<Due>("DueId");
            
            modelBuilder.Entity<Task>()
                .HasOne(d => d.Duration)
                .WithOne(t => t.Task)
                .HasForeignKey<Duration>("DurationId");
        }
    }
}
