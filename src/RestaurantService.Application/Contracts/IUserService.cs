using RestaurantService.Domain.Identity;
namespace RestaurantService.Application.Contracts;

public interface IUserService
{
    Task<User> GetById(int id, CancellationToken ct = default);
    Task<int> Register(string phoneNumber, CancellationToken ct = default);
    Task ApproveByAdmin(int id, CancellationToken ct = default);
}
