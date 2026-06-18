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
        user.ApproveByAdmin();
    }

    public Task<User> GetById(int id, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }

    public Task<int> Register(string phoneNumber, CancellationToken ct = default)
    {
        throw new NotImplementedException();
    }
}
