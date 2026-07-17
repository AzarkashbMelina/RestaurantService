namespace RestaurantService.Domain.Abstractions;

public interface ISoftDelete
{
    bool IsDeleted { get; }
    DateTime? DeletedAt { get; }
    Guid? DeletedBy { get; }
}
