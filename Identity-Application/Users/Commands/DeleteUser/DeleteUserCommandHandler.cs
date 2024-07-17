using Identity_Application.Core.Abstractions.Authentication;
using Identity_Application.Core.Abstractions.CQRS;
using Identity_Application.Core.Abstractions.Data;
using Identity_Application.Users.Commands.CreateUser;
using Identity_Domain.Core.BaseType.Result;
using Identity_Domain.Users;
using Microsoft.Extensions.Logging;
using System.Runtime.CompilerServices;

namespace Identity_Application.Users.Commands.DeleteUser;

internal sealed class DeleteUserCommandHandler : ICommandHandler<DeleteUserCommand, UserDTO>
{
    private readonly IUserRepository _userRepository;
    private readonly IUnitOfWork _unitOfWork;
    private readonly IJwtProvider _jwtProvider;
    private readonly ILogger<DeleteUserCommandHandler> _logger;

    public DeleteUserCommandHandler(IUserRepository userRepository, IUnitOfWork unitOfWork, IJwtProvider jwtProvider, ILogger<DeleteUserCommandHandler> logger)
    {
        _userRepository = userRepository;
        _unitOfWork = unitOfWork;
        _jwtProvider = jwtProvider;
        _logger = logger;
    }

    public async Task<Result<UserDTO>> Handle(DeleteUserCommand request, CancellationToken cancellationToken)
    {
        User? user = await _userRepository.GetUserByIdAsync(request.UserId, cancellationToken);

        if (user is null)
        {

        }
    }
}
