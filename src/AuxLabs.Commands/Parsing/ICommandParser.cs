using System;
using System.Collections.Generic;
using System.Text;

namespace AuxLabs.Commands.Parsing
{
    /// <summary>
    /// Reads a tokenized command and attempts to output a matching command object
    /// </summary>
    public interface ICommandParser
    {
        ICommandLexer Lexer { get; }

        //object Parse();
    }
}
