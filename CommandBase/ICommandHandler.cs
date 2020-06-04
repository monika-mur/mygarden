using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CommandBase
{
    public interface ICommandHandler : IRequestHandler<IRequest>
    {
    }
}
