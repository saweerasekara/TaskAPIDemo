using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
using TaskAPI.Services;
using TaskAPI.Services.Authors;
using TaskAPI.Services.Model;

namespace TaskAPI.Controllers
{
    [Route("api/v1/todos")]
    [ApiController]
    public class TodosController : ControllerBase
    {
        private readonly ITodoHelperServices todoHelperServices;
        private readonly IMapper mapper;

        public TodosController(ITodoHelperServices todoHelperServices, IMapper mapper)
        {
            this.todoHelperServices = todoHelperServices;
            this.mapper = mapper;
        }

        [HttpGet]
        [Route("{authorId}/get-todos")]
        public IActionResult GetTodos(int authorId)
        {
            var todos = mapper.Map<ICollection<TodoDto>>(todoHelperServices.AllTodos(authorId));
            if (todos == null)
                return NotFound();
            return Ok(todos);
        }

        [HttpGet("authors/{authorId}/todo/{id}" , Name = "GetTodo")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todos = mapper.Map<TodoDto>(todoHelperServices.GetById(authorId, id));
            if(todos == null)
                return NotFound();
            return Ok(todos);
        }

        [HttpPost]
        public IActionResult CreateTodo(int authorId , CreateTodoDto todos)
        {
            var createdTodo = todoHelperServices.AddTodo(authorId, mapper.Map<Todo>(todos));
            var returnedTodo = mapper.Map<TodoDto>(createdTodo);

            return CreatedAtRoute("GetTodo", new { authorId = authorId, id = returnedTodo.Id }, returnedTodo);
        }
    }
}
