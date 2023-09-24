using Contracts;
using Entities.Models;

namespace Repository.ModelRepository;

public class AuthorRepository : RepositoryBase<Author>, IAuthorRepository
{
    public AuthorRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
        
    }
}