using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Book
{
    public Guid Id { get; set; }
    public string? BookTitle { get; set; }
    public string? ISBN { get; set; }
    public DateTime PublicationDate { get; set; }
    public string? Description { get; set; }
    public bool Availability { get; set; }
    public int PageCount { get; set; }
    public string? CoverImageURL { get; set; }

    public ICollection<BookAuthor> BookAuthors { get; set; }
    public ICollection<Author> Authors { get; set; }
}