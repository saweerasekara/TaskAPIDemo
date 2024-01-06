using TaskAPI.Models;

namespace TaskAPI.HelperServices
{
    public interface ITodoHelperServices
    {
        List<Todo> AllTodos();

        Todo GetById(int id);
    }
}
