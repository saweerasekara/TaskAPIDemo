using TaskAPI.Models;

namespace TaskAPI.HelperServices
{
    public class TodoHelperServices : ITodoHelperServices
    {
        public List<Todo> AllTodos()
        {
            var todo = new List<Todo>();
            todo.Add(new Todo
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });
            todo.Add(new Todo
            {
                Id = 2,
                Title = "Test2",
                Description = "Test2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });
            todo.Add(new Todo
            {
                Id = 3,
                Title = "Test3",
                Description = "Test3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });

            return todo;
        }

        public Todo GetById(int id)
        {
            var todo = new List<Todo>();
            todo.Add(new Todo
            {
                Id = 1,
                Title = "Test",
                Description = "Test",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });
            todo.Add(new Todo
            {
                Id = 2,
                Title = "Test2",
                Description = "Test2",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });
            todo.Add(new Todo
            {
                Id = 3,
                Title = "Test3",
                Description = "Test3",
                Created = DateTime.Now,
                Due = DateTime.Now.AddDays(2),
                Status = TodoStatus.New
            });

            return todo.Where(x => x.Id == id).First();
        }


    }
}
