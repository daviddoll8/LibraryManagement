using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Author
{
    public Guid Id { get; set; }
    public string? Name { get; set; }
    public DateTime Birthdate { get; set; }
    public string? Biography { get; set; }
    
    public ICollection<BookAuthor> BookAuthors { get; set; }
    public ICollection<Book> Books { get; set; }
}