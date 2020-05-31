using AuxLabs.Commands.Parsing;
using System.Threading.Tasks;

namespace AuxLabs.Commands
{
    public class DefaultCommandService : ICommandService
    {
        public ICommandParser Parser { get; }

        public DefaultCommandService(CommandServiceOptions options = default)
        {
            var lexer = options.CustomLexer ?? new DefaultCommandLexer(options.LexerOptions);
            Parser = options.CustomParser ?? new DefaultCommandParser(lexer, options.ParserOptions);
        }

        public void AddCommands()
        {

        }

        public void Match(ICommandContext context)
            => MatchAsync(context).ConfigureAwait(false).GetAwaiter().GetResult();
        public async Task MatchAsync(ICommandContext context)
        {
            await Task.Delay(0);
        }
    }
}
