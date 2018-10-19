using System;
using CommandLine;

namespace IonDotnet.CLI
{
    [Verb("extract", HelpText =
        "Extract the symbols from the given input(s) into a shared symbol table with the given name and version.")]
    public class ExtractOptions
    {
    }

    public class ExecuteExtract
    {
        public static int Execute(ExtractOptions opts)
        {
            Console.WriteLine("In the execute command");
            return 0;
        }
    }
}