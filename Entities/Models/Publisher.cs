using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Models;

public class Publisher
{
    public Guid PublisherId { get; set; }
    public string? Name { get; set; }
    public string? Location { get; set; }
    public string? ContactInfo { get; set; }
    
    public ICollection<Book> Books { get; set; }
}