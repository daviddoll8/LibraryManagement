using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Genre
{
    public Guid GenreId { get; set; }
    public string? Name { get; set; }

    public ICollection<Book> Books { get; set; }
}