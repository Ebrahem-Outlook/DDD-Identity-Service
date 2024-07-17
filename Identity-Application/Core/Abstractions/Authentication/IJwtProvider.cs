using Identity_Domain.Users;

namespace Identity_Application.Core.Abstractions.Authentication;

public interface IJwtProvider
{
    string GenerateToken(User user);
}
