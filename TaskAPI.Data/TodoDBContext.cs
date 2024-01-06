using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.Data
{
    public class TodoDBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost\SQLExpress; Database=myTodoDb; Integrated Security=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            var todo = new List<Todo>();
            todo.Add(new Todo
            {
                Id = 1,
                Title = "Db record 1",
                Description = "Test",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });
            todo.Add(new Todo
            {
                Id = 2,
                Title = "Db record 2",
                Description = "Test2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });
            todo.Add(new Todo
            {
                Id = 3,
                Title = "Db record 3",
                Description = "Test3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });

            modelBuilder.Entity<Todo>().HasData(todo);
        }
    }
}
