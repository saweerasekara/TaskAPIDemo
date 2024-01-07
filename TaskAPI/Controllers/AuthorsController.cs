using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TaskAPI.Models;
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
            var mappedAuthors = _mapper.Map<ICollection<AuthorDto>>(authors);
            if(mappedAuthors == null)
                return NotFound();
            return Ok(mappedAuthors);
        }

        [HttpGet("{id?}" , Name = "GetAuthors")]
        public IActionResult GetAuthor(int id)
        {
            var author = _authorHelperService.GetAuthor(id);
            if(author == null)
                return NotFound();
            return Ok(author);
        }

        [HttpPost]
        public IActionResult CreateAuthor(CreateAuthorDto author)
        {
            var createdAuthor = _authorHelperService.AddAuthor(_mapper.Map<Author>(author));
            var returnedAuth = _mapper.Map<AuthorDto>(createdAuthor);

            return CreatedAtRoute("GetAuthors", new { id = returnedAuth.Id } , returnedAuth);
        }
    }
}
