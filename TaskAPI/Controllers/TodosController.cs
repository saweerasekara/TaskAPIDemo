using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/v1/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoHelperServices todoHelperServices;

        public TodosController(ITodoHelperServices todoHelperServices)
        {
            this.todoHelperServices = todoHelperServices;
        }

        [HttpGet]
        public IActionResult GetTodos()
        {
            var todos = todoHelperServices.AllTodos();
            if (todos == null)
                return NotFound();
            return Ok(todos);
        }

        [HttpGet("{id?}")]
        public IActionResult GetTodo(int id)
        {
            var todos = todoHelperServices.GetById(id);
            if(todos == null)
                return NotFound();
            return Ok(todos);
        }
    }
}
