﻿using AutoMapper;
using Contracts;
using Service.Contracts;
using Shared.DataTransferObjects;

namespace Service;

internal sealed class BookService : IBookService
{
    private readonly IRepositoryManager _repository;
    private readonly ILoggerManager _logger;
    private readonly IMapper _mapper;

    public BookService(IRepositoryManager repository, ILoggerManager logger, IMapper mapper)
    {
        _repository = repository;
        _logger = logger;
        _mapper = mapper;
    }

    public IEnumerable<BookDto> GetAllBooks(bool trackChanges)
    {
        var books = _repository.Book.GetAllBooks(trackChanges);
        var booksDto = _mapper.Map<IEnumerable<BookDto>>(books);
        
        return booksDto;
    }
}