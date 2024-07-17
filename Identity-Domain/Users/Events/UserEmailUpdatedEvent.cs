using Identity_Domain.Core.Events;

namespace Identity_Domain.Users.Events;

public sealed class UserEmailUpdatedEvent : DomainEvent
{
    public UserEmailUpdatedEvent(Guid userId, string email)
    {
        UserId = userId;
        Email = email;
    }

    public Guid UserId { get; }
    public string Email { get; }
}
