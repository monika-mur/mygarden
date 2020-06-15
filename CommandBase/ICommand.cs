using MediatR;

namespace CommandBase
{
    public interface ICommand<TResponse> : IRequest<TResponse>
    {
    }
}
