using MediatR;

namespace Identity_Application.Core.Abstractions.Messaging;

public interface IQuery<TResponse> : IRequest<TResponse>
    where TResponse : class
{

}
