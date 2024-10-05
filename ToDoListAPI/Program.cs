
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace ToDoListAPI
{
    // https://developer.todoist.com
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Get connection string
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

            // Initialising my DbContext inside the DI Container
            builder.Services.AddDbContext<TodoListContext>(options
                => options.UseNpgsql(connectionString));

            // Add services to the container.
            builder.Services.AddControllers();
            builder.Services.AddScoped<Services.ITaskService, Services.TaskService>();

            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();


            app.MapControllers();

            app.Run();
        }
    }
}
