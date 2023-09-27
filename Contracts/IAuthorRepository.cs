using Entities.Models;

namespace Contracts;

public interface IAuthorRepository
{
    IEnumerable<Author> GetAllAuthors(bool trackChanges);
}