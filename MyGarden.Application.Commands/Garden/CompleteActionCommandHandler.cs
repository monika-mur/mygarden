using System.Threading;
using System.Threading.Tasks;
using CommandBase;
using MediatR;
using MyGarden.Contract.Commands;

namespace MyGarden.Application.Commands
{
    public class CompleteActionCommandHandler : ICommandHandler<CompleteActionCommand>
    {
        public Task<Unit> Handle(ICommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
