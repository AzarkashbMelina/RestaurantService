using RestaurantService.Domain.Base;
using RestaurantService.Domain.Identity;

namespace RestaurantService.Domain.Customers;
//user class should inherit from entity(base class) and IAggregateRoot
internal class Customer : AggregateRoot
{
}
