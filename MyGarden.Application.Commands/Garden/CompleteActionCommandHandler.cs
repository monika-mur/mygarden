using System.Threading;
using System.Threading.Tasks;
using CommandBase;
using MyGarden.Contract.Commands;

namespace MyGarden.Application.Commands
{
    public class CompleteActionCommandHandler : ICommandHandler<CompleteActionCommand, int>
    {
        public Task<int> Handle(CompleteActionCommand request, CancellationToken cancellationToken)
        {
            throw new System.NotImplementedException();
        }
    }
}
