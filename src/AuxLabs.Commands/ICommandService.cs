using AuxLabs.Commands.Parsing;

namespace AuxLabs.Commands
{
    public interface ICommandService
    {
        ICommandParser Parser { get; }
    }
}
