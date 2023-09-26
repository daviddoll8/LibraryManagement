using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

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

    public IEnumerable<BookDto> GetAllBooks(bool trackChanges)
    {
        try
        {
            var books = _repository.Book.GetAllBooks(trackChanges);

            var booksDto = books.Select(b => new BookDto(b.BookId, b.BookTitle,
                b.PublisherId, b.ISBN, b.PublicationDate, b.Description ?? "", b.Availability,
                b.PageCount)).ToList();

            return booksDto;
        }
        catch (Exception ex)
        {
            _logger.LogError($"Something went wrong in the {nameof(GetAllBooks)} service method {ex}");
            throw;
        }
    }
}