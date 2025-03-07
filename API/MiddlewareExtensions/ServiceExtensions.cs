using API.Data;
using API.Repositories;
using API.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.MiddlewareExtensions;

public static class ServiceExtensions
{
    public static void AddDeploymentConfiguration(this IServiceCollection services,
        IConfiguration configuration) =>
        services.Configure<DeploymentConfiguration>(configuration.GetSection("deployment"));
    
    public static void ConfigureSqlContext(this IServiceCollection services,
        IConfiguration configuration) =>
        services.AddDbContext<AssignmentDbContext>(opts =>
        {
            var isDockerEnabled = 
                configuration.GetSection("deployment")
                    .Get<DeploymentConfiguration>()?.IsDockerEnabled ?? false;
            
            if(isDockerEnabled)
                opts.UseSqlServer(configuration.GetConnectionString("sqlConnection"));
            else
            {
                opts.UseInMemoryDatabase("AssignmentsDatabase");
            }
        });
    public static void ConfigureRepositoryManager(this IServiceCollection services) =>
        services.AddScoped<IRepositoryManager, RepositoryManager>();
    
    public static void ConfigureServiceManager(this IServiceCollection services) =>
        services.AddScoped<IServiceManager, ServiceManager>();
}