﻿using Contracts;
using Service.Contracts;

namespace Service;

public sealed class ServiceManager : IServiceManager
{
    private readonly Lazy<IBookService> _bookService;
    private readonly Lazy<IAuthorService> _authorService;
    private readonly Lazy<IPublisherService> _publisherService;
    private readonly Lazy<IGenreService> _genreService;

    public ServiceManager(IRepositoryManager repositoryManager, ILoggerManager logger)
    {
        _bookService = new Lazy<IBookService>(() => new BookService(repositoryManager, logger));
        _publisherService = new Lazy<IPublisherService>(() => new PublisherService(repositoryManager, logger));
        _authorService = new Lazy<IAuthorService>(() => new AuthorService(repositoryManager, logger));
        _genreService = new Lazy<IGenreService>(() => new GenreService(repositoryManager, logger));
    }

    public IBookService BookService => _bookService.Value;
    public IPublisherService PublisherService => _publisherService.Value;
    public IGenreService GenreService => _genreService.Value;
    public IAuthorService AuthorService => _authorService.Value;
}