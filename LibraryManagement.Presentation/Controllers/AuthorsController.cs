using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace LibraryManagement.Presentation.Controllers;

[Route("api/authors")]
[ApiController]
public class AuthorsController : ControllerBase
{
    private readonly IServiceManager _service;
    
    public AuthorsController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetAuthors()
    {
            var books = _service.AuthorService.GetAllAuthors(trackChanges: false);

            return Ok(books);
    }
}