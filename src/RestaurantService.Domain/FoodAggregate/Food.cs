using RestaurantService.Domain.Abstractions;
using RestaurantService.Domain.Base;

namespace RestaurantService.Domain.FoodAggregate;

public class Food :AggregateRoot, IAuditable
{
    public DateTime? CreatedAt { get; set; }
    public string Name { get; set; }
}
