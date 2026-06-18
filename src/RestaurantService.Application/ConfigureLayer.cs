using Microsoft.Extensions.DependencyInjection;

namespace RestaurantService.Application;

public static class ConfigureLayer
{
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        return services;
    }
}
