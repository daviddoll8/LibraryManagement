using Microsoft.AspNetCore.Mvc;
using Service.Contracts;

namespace LibraryManagement.Presentation.Controllers;

[Route("api/books")]
[ApiController]
public class BooksController : ControllerBase
{
    private readonly IServiceManager _service;

    public BooksController(IServiceManager service) => _service = service;

    [HttpGet]
    public IActionResult GetBooks()
    {
        try
        {
            var books = _service.BookService.GetAllBooks(trackChanges: false);

            return Ok(books);
        }
        catch
        {
            return StatusCode(500, "Internal server error");
        }
    }
}