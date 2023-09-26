namespace Shared.DataTransferObjects;

public record BookDto(Guid Id, string BookTitle, Guid PublisherId, string ISBN,
    DateTime PublicationDate, string Description, bool Availability, int PageCount);  