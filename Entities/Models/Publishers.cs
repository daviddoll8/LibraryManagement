using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Publishers
{
    [Column("PublisherId")]
    public Guid Id { get; set; }
    
    [Required(ErrorMessage = "Publisher Name is a required field.")]
    [MaxLength(75, ErrorMessage = "Maximum length for Publisher Name is 75 characters.")]
    public string? Name { get; set; }
    
    [MaxLength(60, ErrorMessage = "Maximum length for Publisher Location is 60 characters.")]
    public string? Location { get; set; }
    
    [MaxLength(100, ErrorMessage = "Maximum length for the Publish Contact Info is 100 characters.")]
    public string? contactInfo { get; set; }
}