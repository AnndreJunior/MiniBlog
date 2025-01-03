using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace MiniBlog.Infra;

public static class DependencyInjection
{
    public static IServiceCollection AddInfra(
        this IServiceCollection services,
        IConfiguration configuration) =>
        services
            .AddConfiguration(configuration);

    private static IServiceCollection AddConfiguration(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}
