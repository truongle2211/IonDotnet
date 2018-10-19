using System;
using CommandLine;
using IonDotnet.Systems;
using IonDotnet.Tree;

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
            if (opts.Input is null)
            {
                Console.WriteLine("Missing input file");
                return 1;
            }
            
//            Console.WriteLine(opts.Input);

            IonDatagram Datagram = IonLoader.Default.Load(opts.Input);

            return 0;
        }
    }
}