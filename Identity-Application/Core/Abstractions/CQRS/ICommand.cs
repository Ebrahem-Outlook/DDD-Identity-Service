using Identity_Domain.Core.BaseType;
using MediatR;

namespace Identity_Application.Core.Abstractions.CQRS;

public interface ICommand : IRequest
{

}

public interface ICommand<TResponse> : IRequest<TResponse>
    where TResponse : Entity
{

}

