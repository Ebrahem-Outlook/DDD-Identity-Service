using MediatR;

namespace Identity_Domain.Core.Events;

public interface IDomainEvent : INotification
{
    Guid Id { get; }

    DateTime OccuresOn { get; }
}
