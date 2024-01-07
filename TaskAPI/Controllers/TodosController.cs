using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services;
using TaskAPI.Services.ViewModels;

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
            var todos = mapper.Map<ICollection<TodoViewModel>>(todoHelperServices.AllTodos(authorId));
            if (todos == null)
                return NotFound();
            return Ok(todos);
        }

        [HttpGet("authors/{authorId}/todo/{id}")]
        public IActionResult GetTodo(int authorId, int id)
        {
            var todos = mapper.Map<TodoViewModel>(todoHelperServices.GetById(authorId, id));
            if(todos == null)
                return NotFound();
            return Ok(todos);
        }
    }
}
