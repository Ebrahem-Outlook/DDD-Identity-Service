using Identity_Domain.Core.Events;

namespace Identity_Domain.Users.Events;

public sealed class UserUpdatedEvent : DomainEvent
{
    public UserUpdatedEvent(string firstName, string lastName)
    {
        FirstName = firstName;
        LastName = lastName;
    }

    public string FirstName { get; }
    public string LastName { get; }
}
