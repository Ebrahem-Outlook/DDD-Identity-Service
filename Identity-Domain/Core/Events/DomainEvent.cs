namespace Identity_Domain.Core.Events;

public abstract class DomainEvent : IDomainEvent
{
    protected DomainEvent()
    {
        Id = Guid.NewGuid();
        OccuresOn = DateTime.UtcNow;
    }

    public Guid Id { get; }

    public DateTime OccuresOn { get; }
}
