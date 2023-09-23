using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class BookGenres
{
    [ForeignKey(nameof(Book))] 
    public Guid BookId;

    [ForeignKey(nameof(Genre))] 
    public Guid GenreId;

}