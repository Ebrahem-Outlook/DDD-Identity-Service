namespace Identity_Domain.Core.BaseType;

public abstract class Entity<TId> : 
{
    protected Entity(Guid id) => Id = id;

    protected Entity() { }

    public Guid Id { get; }

}
