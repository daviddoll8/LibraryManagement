using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class BookAuthors
{
    [ForeignKey(nameof(Books))] 
    public Guid BookId;

    [ForeignKey(nameof(Authors))] 
    public Guid AuthorId;
}