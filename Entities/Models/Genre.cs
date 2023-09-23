using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Genre
{
    [Column("GenreId")]
    public Guid Id { get; set; }

    [Required(ErrorMessage = "Genre name is a required field.")]
    [MaxLength(40, ErrorMessage = "Maximum length for Genre Name is 40 characters.")]
    public string? Name { get; set; }
}