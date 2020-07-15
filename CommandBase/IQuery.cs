using MediatR;

namespace CommandBase
{
    public class IQuery<TResponse> : IRequest<TResponse>
    {
    }
}
