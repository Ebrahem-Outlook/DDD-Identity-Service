using Identity_Domain.Core.Events;

namespace Identity_Domain.Users.Events;

public sealed class UserPasswordUpdatedEvent : DomainEvent
{
    public UserPasswordUpdatedEvent(Guid id, string password)
    {
        UserId = id;
        Password = password;
    }

    public Guid UserId{ get; }
    public string Password { get; }
}
