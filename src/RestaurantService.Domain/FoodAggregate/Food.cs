using RestaurantService.Domain.Abstractions;

namespace RestaurantService.Domain.FoodAggregate;

public class Food : ICreatable
{
    public DateTime? CreatedAt { get; set; }
    public string Name { get; set; }
}
