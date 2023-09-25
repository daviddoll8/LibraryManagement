using Contracts;
using Service.Contracts;

namespace Service;

internal sealed class GenreService : IGenreService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public GenreService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }
}