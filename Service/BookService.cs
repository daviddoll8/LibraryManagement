using Contracts;
using Entities.Models;
using Service.Contracts;

namespace Service;

internal sealed class BookService : IBookService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;

    public BookService(IRepositoryManager repository, ILoggerManager logger)
    {
        _repository = repository;
        _logger = logger;
    }

    public IEnumerable<Book> GetAllBooks(bool trackChanges)
    {
        try
        {
            var books = _repository.Book.GetAllBooks(trackChanges);

            return books;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Something went wrong in the {nameof(GetAllBooks)} service method");
            throw;
        }
    }
}