using RestaurantService.Domain.Shared.ValueObjects;

namespace RestaurantService.Domain.Restaurants;
//it should inherit from entity(base class) and IAggregateRoot
public class Restaurant
{
    public string Name { get; set; }
    public string Category { get; set; }
    public string Description { get; set; }
    public Address Address { get; set; }
}
