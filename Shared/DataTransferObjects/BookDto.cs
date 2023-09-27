namespace Shared.DataTransferObjects;

public record BookDto(Guid BookId, string BookTitle, Guid PublisherId, string ISBN,
    DateTime PublicationDate, string Description, bool Availability, int PageCount);  