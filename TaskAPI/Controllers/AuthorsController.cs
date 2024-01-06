using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Services;

namespace TaskAPI.Controllers
{
    [Route("api/v1/authors")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorHelperService _authorHelperService;
        public AuthorsController(IAuthorHelperService _authorHelperService)
        {
            this._authorHelperService = _authorHelperService;
        }

        [HttpGet]
        public IActionResult GetAuthors()
        {
            var authors = _authorHelperService.GetAuthors();
            if(authors == null)
                return NotFound();
            return Ok(authors);
        }

        [HttpGet("{id?}")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorHelperService.GetAuthor(id);
            if(author == null)
                return NotFound();
            return Ok(author);
        }
    }
}
