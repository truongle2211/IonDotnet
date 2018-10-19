using System;
using CommandLine;

namespace IonDotnet.CLI
{
    [Verb("compare", HelpText =
        "Compare all inputs (which may contain Ion streams and/or EventStreams) against all other inputs using the Ion data model's definition of equality. Write a ComparisonReport to the output.")]
    public class CompareOptions : BaseOptions
    {
    }

    public class ExecuteCompare
    {
        public static int Execute(CompareOptions opts)
        {
            Console.WriteLine($"this is the thing that passes in {opts.Verbose}");
            return 0;
        }
    }
}