using Microsoft.AspNetCore.Mvc;
using TaskAPI.HelperServices;

namespace TaskAPI.Controllers
{
    [Route("api/v1/[controller]")]
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
            return Ok(todos);
        }

        [HttpGet("{id}")]
        public IActionResult GetTodo(int id)
        {
            var todos = todoHelperServices.GetById(id);
            return Ok(todos);
        }
    }
}
