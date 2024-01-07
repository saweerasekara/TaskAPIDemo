using Microsoft.EntityFrameworkCore;
using TaskAPI.Models;

namespace TaskAPI.Data
{
    public class DBContext : DbContext
    {
        public DbSet<Todo> Todos { get; set; }

        public DbSet<Author> Authors { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var connectionString = @"Server=localhost\SQLExpress; Database=myTodoDb; Integrated Security=True; TrustServerCertificate=True";
            optionsBuilder.UseSqlServer(connectionString);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Author>().HasData(new Author[]
            {
                new Author { Id = 1, FullName = "Name 1", AddressNo = "10", Street = "street1", City="city1", JobRole = "Developer"},
                new Author { Id = 2, FullName = "Name 2",AddressNo = "11", Street = "street2", City="city2", JobRole = "Developer"},
                new Author { Id = 3, FullName = "Name 3", AddressNo = "12", Street = "street3", City = "city3", JobRole = "System Enginner"},
                new Author { Id = 4, FullName = "Name 4", AddressNo = "13", Street = "street4", City = "city4", JobRole = "QA"},
            });

            modelBuilder.Entity<Todo>().HasData(new Todo[]
            {
                new Todo
            {
                Id = 1,
                Title = "Db record 1",
                Description = "Test",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New,
                AuthorId = 1,
            },
                new Todo
            {
                Id = 2,
                Title = "Db record 2",
                Description = "Test2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New,
                AuthorId = 2,
            },
                new Todo
            {
                Id = 3,
                Title = "Db record 3",
                Description = "Test3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New,
                AuthorId = 3,
            }
            });
        }
    }
}
