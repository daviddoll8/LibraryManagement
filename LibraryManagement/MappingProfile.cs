using AutoMapper;
using Entities.Models;
using Shared.DataTransferObjects;

namespace LibraryManagement;

public class MappingProfile : Profile
{
    public MappingProfile()
    {
        CreateMap<Book, BookDto>();
        CreateMap<Author, AuthorDto>();
    }
}