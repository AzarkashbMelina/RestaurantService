using Microsoft.EntityFrameworkCore;
using RestaurantService.Infrastructure;
using RestaurantService.Persistence.Contexts;

namespace RestaurantService.Api;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);
        bool isDevelop = true;
        // Add services to the container.

        builder.Services.AddControllers();

        //add swagger
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddOpenApi();
        builder.Services.AddSwaggerGen();

        //add healthcheck
        builder.Services.AddHealthChecks();

        //DI            
        string connectionString = builder.Configuration.
            GetConnectionString("AppDbContext") ?? string.Empty;

        builder.Services.AddInfrastructureLayer(isDevelop, connectionString);

        builder.Services.AddDbContext<AppDbContext>(options =>
                options.UseSqlServer(connectionString));

        var app = builder.Build();
   
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI(options => 
            {
                options.SwaggerEndpoint("/swagger/v1/swagger.json", "RestaurantService API v1");
            });
            
        }

        // Configure the HTTP request pipeline.
        
        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapHealthChecks("/healthz");

        app.MapControllers();

        app.Run();
    }
}
