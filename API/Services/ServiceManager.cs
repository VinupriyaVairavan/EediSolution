using API.Repositories;
using AutoMapper;

namespace API.Services;

public class ServiceManager(IRepositoryManager repositoryManager, IMapper mapper) : IServiceManager
{
    private readonly Lazy<IImproveService> _improveService = new(() => new ImproveService(repositoryManager, mapper));
    public IImproveService ImproveService => _improveService.Value;
}