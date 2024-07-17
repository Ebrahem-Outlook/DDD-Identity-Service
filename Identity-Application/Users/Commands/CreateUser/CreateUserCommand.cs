using Identity_Application.Core.Abstractions.CQRS;
using Identity_Domain.Users;

namespace Identity_Application.Users.Commands.CreateUser;

public sealed class CreateUserCommand : ICommand<UserDTO>
{
}
