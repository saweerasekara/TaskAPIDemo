using TaskAPI.Models;

namespace TaskAPI.Services
{
    public interface ITodoHelperServices
    {
        List<Todo> AllTodos(int author);

        Todo GetById(int authoerId, int id);

        Todo AddTodo(int authorId, Todo todo);
    }
}
