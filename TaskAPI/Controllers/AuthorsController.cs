using AutoMapper;
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
        private readonly IMapper _mapper;
        public AuthorsController(IAuthorHelperService _authorHelperService, IMapper _mapper)
        {
            this._authorHelperService = _authorHelperService;
            this._mapper = _mapper;
        }

        [HttpGet]
        public IActionResult GetAuthors(string? job, string? search) // read as query string
        {
            //var authors = _authorHelperService.GetAuthors();
            var authors = _authorHelperService.GetAuthors(job, search);
            var mappedAuthors = _mapper.Map<ICollection<AuthorViewModel>>(authors);
            if(mappedAuthors == null)
                return NotFound();
            return Ok(mappedAuthors);
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
