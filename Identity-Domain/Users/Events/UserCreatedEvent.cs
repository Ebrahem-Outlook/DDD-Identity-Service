using Identity_Domain.Core.Events;

namespace Identity_Domain.Users.Events;

public sealed class UserCreatedEvent : DomainEvent
{
    public UserCreatedEvent(Guid id, string firstName, string lastName, string email, string password)
    {
        UserId = id;
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    public Guid UserId { get; }
    public string FirstName { get; }
    public string LastName { get; }
    public string Email { get; }
    public string Password { get; }
}
