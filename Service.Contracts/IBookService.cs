using Shared.DataTransferObjects;

namespace Service.Contracts;

public interface IBookService
{
    IEnumerable<BookDto> GetAllBooks(bool trackChanges);
}