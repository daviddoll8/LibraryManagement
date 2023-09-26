using Contracts;
using Entities.Models;

namespace Repository.ModelRepository;

public class BookRepository : RepositoryBase<Book>, IBookRepository
{
    public BookRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
        
    }

    public IEnumerable<Book> GetAllBooks(bool trackChanges) =>
        FindAll(trackChanges).OrderBy(b => b.BookTitle).ToList();
}