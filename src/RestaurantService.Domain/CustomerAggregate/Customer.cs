using RestaurantService.Domain.Abstractions;
using RestaurantService.Domain.Base;
using RestaurantService.Domain.Identity;

namespace RestaurantService.Domain.Customers;
//user class should inherit from entity(base class) and IAggregateRoot
public class Customer : AggregateRoot, IAuditableEntity
{
    public int CustomerId { get; set; }
    public int UserId { get; set; }
    public DateTime CreatedAt { get; }

    public DateTime? LastModifiedAt { get; }
}
