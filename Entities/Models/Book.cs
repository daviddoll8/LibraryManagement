using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Book
{
    public Guid BookId { get; set; }
    public Guid PublisherId { get; set; }
    public string? BookTitle { get; set; }
    public string? ISBN { get; set; }
    public DateTime PublicationDate { get; set; }
    public string? Description { get; set; }
    public bool Availability { get; set; }
    public int PageCount { get; set; }
    public string? CoverImageURL { get; set; }

    public ICollection<Genre> Genres { get; set; } = new List<Genre>();
    public Publisher Publisher { get; set; } = null!;
    public ICollection<BookAuthor> BookAuthors { get; set; }
    public ICollection<Author> Authors { get; set; }
}