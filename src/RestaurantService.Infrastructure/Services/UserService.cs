using Microsoft.EntityFrameworkCore;
using RestaurantService.Application.Contracts;
using RestaurantService.Domain.Identity;
using RestaurantService.Persistence.Contexts;

namespace RestaurantService.Infrastructure.Services;

public class UserService : IUserService
{
    private readonly AppDbContext _dbContext;
    public UserService(AppDbContext dbContext)
    {
        _dbContext = dbContext;
    }
    public async Task ApproveByAdmin(int id, CancellationToken ct = default)
    {
        User user = await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
        user.ApproveUser();
    }

    public async Task<User> GetById(int id, CancellationToken ct = default)
    {
        return await _dbContext.Users.FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task<int> Register(string phoneNumber, CancellationToken ct = default)
    {
        User user = User.Register("Fname", "Lname", "phoneNumber", "nc");

        _dbContext.Users.Add(user);
        await _dbContext.SaveChangesAsync(ct);
        return user.Id;
    }
}
