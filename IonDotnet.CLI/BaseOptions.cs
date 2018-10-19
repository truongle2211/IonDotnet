using CommandLine;

namespace IonDotnet.CLI
{
    public abstract class BaseOptions
    {
        [Option('v', "verbose", Required = true, HelpText = "Set Output to verbose message.")]
        public string Verbose { get; set; }

        [Option('o', "output", Required = true, HelpText = "set output file")]
        public string Output { get; set; }

        [Option('f', "output-format", Required = true, HelpText = "set output format")]
        public string OutputFormat { get; set; }
    }
}