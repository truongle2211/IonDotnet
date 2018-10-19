using System;
using CommandLine;

namespace IonDotnet.CLI
{
    [Verb("process", HelpText =
        "Read the input file(s) (optionally, specifying ReadInstructions or a filter) and re-write in the format specified by --output.")]
    public class ProcessOptions : BaseOptions
    {
    }
    
    public class ExecuteProcess
    {
        public static int Execute(ProcessOptions opts)
        {
            Console.WriteLine($"this is the thing that passes in {opts.Verbose}");
            return 0;
        }

    }
}