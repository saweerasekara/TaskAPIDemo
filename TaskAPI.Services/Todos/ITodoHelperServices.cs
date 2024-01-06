using TaskAPI.Models;

namespace TaskAPI.Services
{
    public interface ITodoHelperServices
    {
        List<Todo> AllTodos();

        Todo GetById(int id);
    }
}
