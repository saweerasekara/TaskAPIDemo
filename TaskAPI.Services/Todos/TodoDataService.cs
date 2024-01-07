using TaskAPI.Data;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoDataService : ITodoHelperServices
    {
        private readonly DBContext _dbContext = new DBContext();

        public List<Todo> AllTodos(int author)
        {
            if(author != (int)default)
                return _dbContext.Todos.Where(record => record.AuthorId == author).ToList();
            return _dbContext.Todos.ToList();
        }

        public Todo GetById(int authoerId, int id)
        {
            return _dbContext.Todos.FirstOrDefault(record => record.Id == id && record.AuthorId == authoerId);
        }

    }
}
