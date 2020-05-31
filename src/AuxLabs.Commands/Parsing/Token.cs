using System;

namespace AuxLabs.Commands.Parsing
{
    public enum TokenType
    {
        Raw,

        // The first value before a separator is reached (command)
        Name,

        // A value indicating a new model has been reached (command arg)
        ArgumentSeparator,
        // A value indicating a named argument will follow (command --arg)
        ArgumentPrefix,
        // A value indicating a specific argument to be used (command --arg)
        ArgumentName,
        // A value indicating an argument's value will follow (command --arg=value)
        ArgumentSetter,
        // A value indicating the value of an argument (command --arg=value) (command value)
        ArgumentValue,

        // A value between these two tokens will be read as a raw value (command "a single value")
        OpenParent,
        // If closed parent is null, open is used in it's place
        CloseParent
    }

    public struct Token
    {
        public readonly TokenType Type;
        public readonly int StartIndex;
        public readonly int EndIndex;

        public Token(TokenType type, int start, int end)
        {
            Type = type;
            StartIndex = start;
            EndIndex = end;
        }

        public string GetText(string text)
        {
            if (StartIndex < text.Length && EndIndex < text.Length)
                return text.Substring(StartIndex, EndIndex - StartIndex + 1);
            return null;
        }

        public override string ToString()
            => $"{Type}({StartIndex}:{EndIndex})";
    }
}
