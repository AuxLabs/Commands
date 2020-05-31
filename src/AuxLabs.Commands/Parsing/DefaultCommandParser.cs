using System;

namespace AuxLabs.Commands.Parsing
{
    public class DefaultCommandParser : ICommandParser
    {
        public ICommandLexer Lexer { get; }

        public DefaultCommandParser(ICommandLexer lexer, ParserOptions options = default)
        {
            Lexer = lexer ?? throw new ArgumentException(nameof(lexer));
        }
    }
}
