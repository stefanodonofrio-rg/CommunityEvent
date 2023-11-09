using System;

namespace LambdaExpressionC9
{
    internal class NoAttribute
    {
        static Action<string> WriteOutputAsString = (string output) => Console.WriteLine(output);
        static Action<string> WriteOutputAsStringNew = (string output) => Console.WriteLine($"New {output}");

        static void Main(string[] args)
        {
            WriteOutputAsString("Hello Community!");
        }
    }
}
