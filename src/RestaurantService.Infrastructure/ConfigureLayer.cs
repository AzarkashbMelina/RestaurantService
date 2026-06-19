using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using RestaurantService.Application.Contracts;
using RestaurantService.Infrastructure.Services;
using RestaurantService.Persistence.Contexts;

namespace RestaurantService.Infrastructure;

public static class ConfigureLayer
{
    //we add a new method to IServiceCollection
    //this file is use for connecting our project to the world(database, services, external apis)
    public static IServiceCollection AddInfrastructureLayer(this IServiceCollection services,
        bool isDevelop, string connectionstring)
    {
        if (isDevelop)
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseInMemoryDatabase("LocalDb")); //develop
        }
        else
        {
            services.AddDbContext<AppDbContext>(options =>
            options.UseSqlServer(connectionstring)).AddHealthChecks();
        }

        services.AddScoped<IUserService, UserService>();

        return services;
    }
}
