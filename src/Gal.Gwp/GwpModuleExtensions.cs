using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;

namespace Gal.Gwp
{
    public static class GwpModuleExtensions
    {
        public static IServiceCollection AddGwpModule(this IServiceCollection services)
        {
            services.TryAddSingleton<IGwpModule, GwpModule>();
            return services;
        }
    }
}
