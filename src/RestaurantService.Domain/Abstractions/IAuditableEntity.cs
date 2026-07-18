namespace RestaurantService.Domain.Abstractions;

public interface IAuditableEntity
{
    DateTime CreatedAt { get; }
    Guid CreatedBy { get; }


    DateTime? UpdatedAt { get; }
    Guid? UpdatedBy { get; }
    
}
