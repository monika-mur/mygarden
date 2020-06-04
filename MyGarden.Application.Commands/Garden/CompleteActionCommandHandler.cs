using System.Threading;
using System.Threading.Tasks;
using CommandBase;
using MediatR;

namespace MyGarden.Application.Commands
{
    public class CompleteActionCommandHandler : ICommandHandler
    {
        public Task<Unit> Handle(IRequest request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
