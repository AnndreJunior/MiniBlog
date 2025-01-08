namespace MiniBlog.Api.Common.Extensions;

public static class ConfigurationExtensions
{
    public static IServiceCollection AddConfiguration(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        return services;
    }
}
