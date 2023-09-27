using Contracts;
using Entities.Models;

namespace Repository.ModelRepository;

public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
{
    public AuthorRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
        
    }

    public IEnumerable<Author> GetAllAuthors(bool trackChanges) =>
        FindAll(trackChanges).OrderBy(a => a.Name).ToList();
}