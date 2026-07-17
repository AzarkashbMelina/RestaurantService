using RestaurantService.Domain.Abstractions;

namespace RestaurantService.Domain.Base;

public abstract class AggregateRoot : Entity, IAggregateRoot
{
    protected AggregateRoot() //it will generate guid v7 from entity base class
    { 
    }
}
