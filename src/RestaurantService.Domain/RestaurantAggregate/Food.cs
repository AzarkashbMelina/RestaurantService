using RestaurantService.Domain.Abstractions;

namespace RestaurantService.Domain.Restaurants;

public class Food : ICreatable
{
    public DateTime? CreatedAt { get; set; }
    public string Name { get; set; }
}
