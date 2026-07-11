using RestaurantService.Domain.Abstractions;
using RestaurantService.Domain.Base;

namespace RestaurantService.Domain.Orders;
//it should inherit from entity(base class) and IAggregateRoot
public class Order : AggregateRoot, IAuditableEntity
{
    public int Id { get; private set; }
}
