namespace Shared.DataTransferObjects;

public record AuthorDto(Guid AuthorId, string Name, DateTime Birthdate, string Biography);