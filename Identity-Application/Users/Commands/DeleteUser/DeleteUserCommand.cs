using Identity_Application.Core.Abstractions.CQRS;
using Identity_Application.Users.Commands.CreateUser;

namespace Identity_Application.Users.Commands.DeleteUser;

/// <summary>
/// Represent the Delete User Command class.
/// </summary>
public sealed class DeleteUserCommand : ICommand<UserDTO>
{
    /// <summary>
    /// Initialize a new instance of the <see cref="DeleteUserCommand"/> class.
    /// </summary>
    /// <param name="userId"></param>
    public DeleteUserCommand(Guid userId)
    {
        UserId = userId;
    }

    /// <summary>
    /// Gets the User Id.
    /// </summary>
    public Guid UserId { get; }
}
