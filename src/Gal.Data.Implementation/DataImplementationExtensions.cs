using Gal.Data.Abstractions.Repositories;
using Gal.Data.Implementation.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Gal.Data.Implementation
{
    public static class DataImplementationExtensions
    {
        public static IServiceCollection AddDataRepositories(this IServiceCollection services)
        {
            services.TryAddSingleton<IGwpRepository, GwpRepository>();
            return services;
        }
    }
}
