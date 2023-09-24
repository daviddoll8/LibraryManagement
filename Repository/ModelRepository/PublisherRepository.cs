using Contracts;
using Entities.Models;

namespace Repository.ModelRepository;

public class PublisherRepository : RepositoryBase<Publisher>, IPublisherRepository
{
    public PublisherRepository(RepositoryContext repositoryContext)
        : base(repositoryContext)
    {
        
    }
}