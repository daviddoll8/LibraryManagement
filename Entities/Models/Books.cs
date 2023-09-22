using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Books
{
    [Column("BookId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Book Title is a required field.")]
    [MaxLength(20, ErrorMessage = "Maximum length for the Book Title is 20 characters.")]
    public string? BookTitle { get; set; }
    
    [Required(ErrorMessage = "ISBN is a required field")]
    [MaxLength(13, ErrorMessage = "Maximum length for the ISBN is 13 characters.")]
    public string? ISBN { get; set; }
    
    [Required(ErrorMessage = "Publication Date is a required field.")]
    public DateTime PublicationDate { get; set; }
    
    [MaxLength(750, ErrorMessage = "Maximum length for the description is 750 characters")]
    public string Description { get; set; }
    
    public bool Availability { get; set; }
    
    [Required(ErrorMessage = "Page Count is a required field.")]
    public int PageCount { get; set; }
    
    public string? CoverImageURL { get; set; }
    
    [ForeignKey(nameof(Publishers))]
    public Guid PublisherId { get; set; }
}