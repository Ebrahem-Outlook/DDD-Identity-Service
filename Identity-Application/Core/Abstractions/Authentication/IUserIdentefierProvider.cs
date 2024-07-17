namespace Identity_Application.Core.Abstractions.Authentication;

public interface IUserIdentefierProvider
{
    Guid UserId { get; }
}
