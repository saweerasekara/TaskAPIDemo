using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TaskAPI.Data;
using TaskAPI.HelperServices;
using TaskAPI.Models;

namespace TaskAPI.Services
{
    public class TodoDataService : ITodoHelperServices
    {
        private readonly TodoDBContext _dbContext = new TodoDBContext();

        public List<Todo> AllTodos()
        {
            return _dbContext.Todos.ToList();
        }

        public Todo GetById(int id)
        {
            return _dbContext.Todos.Where(record => record.Id == id).First();
        }
    }
}
