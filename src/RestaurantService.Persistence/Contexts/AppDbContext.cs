using Microsoft.EntityFrameworkCore;
using RestaurantService.Domain.Identity;

namespace RestaurantService.Persistence.Contexts;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }
    public DbSet<User> Users { get; set; }

}
