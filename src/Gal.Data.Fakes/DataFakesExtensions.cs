using Gal.Data.Abstractions.Repositories;
using Gal.Data.Fakes.Database;
using Gal.Data.Fakes.Repositories;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Gal.Data.Fakes
{
    public static class DataFakesExtensions
    {
        public static IServiceCollection AddFakeRepositories(this IServiceCollection services)
        {
            services.AddSingleton<FakeDatabase>();
            services.TryAddSingleton<IGwpRepository, GwpFakeRepository>();

            return services;
        }
    }
}
