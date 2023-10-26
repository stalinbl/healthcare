
using Microsoft.Extensions.DependencyInjection;

namespace Healthcare.IoC
{
    public static class DependencyExtension
    {
        public static IServiceCollection AddDependency(this IServiceCollection service)
        {
            return service;
        }
    }
}
