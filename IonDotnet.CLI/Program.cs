using CommandLine;

namespace IonDotnet.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length == 0)
            {
                InteractiveOptions.Execute();
                return;
            }

            Parser.Default.ParseArguments<ProcessOptions, ExtractOptions, ExtractOptions>(args).MapResult(
                (ProcessOptions opts) => ExecuteProcess.Execute(opts),
                (CompareOptions opts) => ExecuteCompare.Execute(opts),
                (ExtractOptions opts) => ExecuteExtract.Execute(opts),
                errs => 1
            );
        }
    }
}