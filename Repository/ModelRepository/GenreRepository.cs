using Contracts;
using Entities.Models;

namespace Repository.ModelRepository;

public class GenreRepository : RepositoryBase<Genre>, IGenreRepository
{
    public GenreRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
        
    }
}