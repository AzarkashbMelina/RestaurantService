namespace RestaurantService.Domain.Orders;
//it should inherit from entity(base class) and IAggregateRoot
public class Order
{
    public int Id { get; private set; }
}
