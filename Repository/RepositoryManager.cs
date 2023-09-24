using Contracts;
using Repository.ModelRepository;

namespace Repository;

public sealed class RepositoryManager : IRepositoryManager
{
    private readonly RepositoryContext _repositoryContext;
    private readonly Lazy<IAuthorRepository> _authorRepository;
    private readonly Lazy<IPublisherRepository> _publisherRepository;
    private readonly Lazy<IGenreRepository> _genreRepository;
    private readonly Lazy<IBookRepository> _bookRepository;

    public RepositoryManager(RepositoryContext repositoryContext)
    {
        _repositoryContext = repositoryContext;
        _authorRepository = new Lazy<IAuthorRepository>(() => new AuthorRepository(repositoryContext));
        _publisherRepository = new Lazy<IPublisherRepository>(() => new PublisherRepository(repositoryContext));
        _bookRepository = new Lazy<IBookRepository>(() => new BookRepository(repositoryContext));
        _genreRepository = new Lazy<IGenreRepository>(() => new GenreRepository(repositoryContext));
    }

    public IAuthorRepository Author => _authorRepository.Value;
    public IPublisherRepository Publisher => _publisherRepository.Value;
    public IGenreRepository Genre => _genreRepository.Value;
    public IBookRepository Book => _bookRepository.Value;

    public void Save() => _repositoryContext.SaveChanges();
}