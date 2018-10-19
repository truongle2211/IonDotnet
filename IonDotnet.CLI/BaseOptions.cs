using System.IO;
using CommandLine;

// ReSharper disable InconsistentNaming
// ReSharper disable UnusedAutoPropertyAccessor.Global

namespace IonDotnet.CLI
{
    public enum Format
    {
        none = 0,
        pretty = 1,
        text = 2,
        binary = 3,
        events = 4
    }

    public abstract class BaseOptions
    {
        [Option('i', "input", Required = false, HelpText = "Set input format")]
        public FileInfo Input { get; set; }

        [Option('o', "output", Default = "stdout", Required = false, HelpText = "set output file")]
        public string Output { get; set; }

        [Option('e', "error-report", Default = "stderr", Required = false, HelpText = "ErrorReport location. [default: stderr]")]
        public string ErrorOutput { get; set; }

        [Option('f', "output-format", Default = Format.pretty, Required = false, HelpText = "set output format")]
        public Format OutputFormat { get; set; }
    }
}