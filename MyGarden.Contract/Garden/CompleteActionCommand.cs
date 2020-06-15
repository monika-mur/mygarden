using MyGarden.Web.Models;
using CommandBase;

namespace MyGarden.Contract.Commands
{
    public class CompleteActionCommand : CompleteActionRequest, ICommand<int>
    {
    }
}
