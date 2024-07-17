﻿using Identity_Domain.Core.Events;

namespace Identity_Domain.Core.BaseType;

public abstract class AggregateRoot : Entity
{
    protected AggregateRoot(Guid id) : base(id) { }

    protected AggregateRoot() : base() { }

    private readonly List<IDomainEvent> domainEvents = new List<IDomainEvent>();

    public IReadOnlyCollection<IDomainEvent> DomainEvents => domainEvents.AsReadOnly();

    public void Raise(IDomainEvent @event) => domainEvents.Add(@event);

    public void Clear() => domainEvents.Clear();
}
