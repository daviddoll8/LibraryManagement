using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class BookGenres
{
    [ForeignKey(nameof(Books))] 
    public Guid BookId;

    [ForeignKey(nameof(Genres))] 
    public Guid GenreId;

}