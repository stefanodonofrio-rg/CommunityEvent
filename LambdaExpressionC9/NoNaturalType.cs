using System;

namespace LambdaExpressionC9
{
    internal class NoNaturalType
    {
        public void Example()
        {
            Func<int, int, int> Add = (int x, int y) => x + y;
            Action<int> WriteOutput = (int x) => Console.WriteLine(x);
        }
    }
}
