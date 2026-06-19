using Microsoft.Extensions.DependencyInjection;

namespace RestaurantService.Application;

public static class ConfigureLayer
{
    //validator, cqrs(mediatr), dto mapping, business rules
    public static IServiceCollection AddApplicationLayer(this IServiceCollection services)
    {
        return services;
    }
}
