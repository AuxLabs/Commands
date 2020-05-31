using AuxLabs.Commands.Parsing;

namespace AuxLabs.Commands
{
    public class CommandServiceOptions
    {
        public ICommandLexer CustomLexer { get; set; } = null;
        public LexerOptions LexerOptions { get; set; } = default;
        public ICommandParser CustomParser { get; set; } = null;
        public ParserOptions ParserOptions { get; set; } = default;
    }
}
