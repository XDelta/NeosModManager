using Serilog.Sinks.SystemConsole.Themes;
using System.Collections.Generic;


namespace NeosModManager.Extensions;
internal class SerilogThemeExtension
{
    public static AnsiConsoleTheme ConsoleTheme { get; } = new AnsiConsoleTheme(
        new Dictionary<ConsoleThemeStyle, string>
        {
            [ConsoleThemeStyle.Text] = EscSeq.Unthemed,
            [ConsoleThemeStyle.SecondaryText] = EscSeq.DarkGray,
            [ConsoleThemeStyle.TertiaryText] = EscSeq.DarkGray,
            [ConsoleThemeStyle.Invalid] = EscSeq.Invalid,
            [ConsoleThemeStyle.Null] = EscSeq.Blue,
            [ConsoleThemeStyle.Name] = EscSeq.Unthemed,
            [ConsoleThemeStyle.String] = EscSeq.Cyan,
            [ConsoleThemeStyle.Number] = EscSeq.Magenta,
            [ConsoleThemeStyle.Boolean] = EscSeq.Blue,
            [ConsoleThemeStyle.Scalar] = EscSeq.Green,
            [ConsoleThemeStyle.LevelVerbose] = EscSeq.Magenta,
            [ConsoleThemeStyle.LevelDebug] = EscSeq.BrightCyan,
            [ConsoleThemeStyle.LevelInformation] = EscSeq.BrightGreen,
            [ConsoleThemeStyle.LevelWarning] = EscSeq.BrightYellow,
            [ConsoleThemeStyle.LevelError] = EscSeq.BrightRed,
            [ConsoleThemeStyle.LevelFatal] = EscSeq.BrightRed,
        }
    );

    //AnsiEscapeSequence
    public static class EscSeq
    {
        public const string Unthemed = "";
        public const string Reset = "\x1b[0m";
        public const string Bold = "\x1b[1m";
        public const string Invalid = "\x1b[33;1m";

        public const string DarkGray = "\x1b[38;5;0246m";

        public const string Black = "\x1b[30m";
        public const string Red = "\x1b[31m";
        public const string Green = "\x1b[32m";
        public const string Yellow = "\x1b[33m";
        public const string Blue = "\x1b[34m";
        public const string Magenta = "\x1b[35m";
        public const string Cyan = "\x1b[36m";
        public const string White = "\x1b[37m";

        public const string BrightBlack = "\x1b[30;1m";
        public const string BrightRed = "\x1b[31;1m";
        public const string BrightGreen = "\x1b[32;1m";
        public const string BrightYellow = "\x1b[33;1m";
        public const string BrightBlue = "\x1b[34;1m";
        public const string BrightMagenta = "\x1b[35;1m";
        public const string BrightCyan = "\x1b[36;1m";
        public const string BrightWhite = "\x1b[37;1m";

        public const string BGRed = "\x1b[41;1m";
    }
}
