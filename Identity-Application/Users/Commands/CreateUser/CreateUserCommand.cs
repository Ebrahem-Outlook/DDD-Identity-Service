using Identity_Application.Core.Abstractions.CQRS;
using Identity_Domain.Users;

namespace Identity_Application.Users.Commands.CreateUser;

public sealed class CreateUserCommand : ICommand<UserDTO>
{
    /// <summary>
    /// Initialize a new instance of <see cref="CreateUserCommand"/> class.
    /// </summary>
    /// <param name="firstName">The First Name of user command.</param>
    /// <param name="lastName">The Last Name of user command.</param>
    /// <param name="email">The Email of user command.</param>
    /// <param name="password">The Password of user command.</param>
    public CreateUserCommand(string firstName, string lastName, string email, string password)
    {
        FirstName = firstName;
        LastName = lastName;
        Email = email;
        Password = password;
    }

    /// <summary>
    /// Gets the First Name user command.
    /// </summary>
    public string FirstName { get; }

    /// <summary>
    /// Gets the Last Name user command.
    /// </summary>
    public string LastName { get; }

    /// <summary>
    /// Gets the Email user command.
    /// </summary>
    public string Email { get; }

    /// <summary>
    /// Gets the Password user command.
    /// </summary>
    public string Password { get; }
}
