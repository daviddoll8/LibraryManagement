using Contracts;
using Entities.Models;

namespace Repository.ModelRepository;

public class BookRepository : RepositoryBase<Book>, IBookRepository
{
    public BookRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
        
    }
}