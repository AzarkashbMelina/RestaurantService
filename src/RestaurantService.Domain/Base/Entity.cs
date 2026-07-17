using RestaurantService.Domain.Abstractions;

namespace RestaurantService.Domain.Base;

public abstract class Entity : IEntity
{
    protected Entity()
    {
        Id = Guid.CreateVersion7();
    }

    public Guid Id { get; private set; }    
}
