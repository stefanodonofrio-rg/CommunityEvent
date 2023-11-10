using System;

namespace LambdaExpressionC9
{
    internal class NoNaturalType
    {
        public void Example()
        {
            var Add = (int x, int y) => x + y;
            var WriteOutput = (int x) => Console.WriteLine(x);
        }
    }
}
