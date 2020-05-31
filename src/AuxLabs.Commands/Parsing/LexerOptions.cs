namespace AuxLabs.Commands.Parsing
{
    public class LexerOptions
    {
        public string ArgumentSeparator { get; set; } = " ";
        public string ArgumentPrefix { get; set; } = "--";
        public string ArgumentSetter { get; set; } = "=";
        public string OpenParent { get; set; } = "\"";
        public string CloseParent { get; set; } = null;
    }
}
