using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Authors
{
    [Column("AuthorId")] 
    public Guid Id;
    
    [Required(ErrorMessage = "Author Name is a required field.")]
    [MaxLength(50, ErrorMessage = "Maximum length for the Name is 50 characters.")]
    public string? Name { get; set; }
    
    [Required(ErrorMessage = "Author Birthdate is a required field.")]
    public DateTime Birthdate { get; set; }
    
    [MaxLength(750, ErrorMessage = "Maximum length for the Author Biography is 750 characters.")]
    public string? Biography { get; set; }
}