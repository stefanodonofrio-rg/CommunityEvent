namespace LambdaExpressionC10
{
    internal class WithNaturalTypeInferred
    {
        public void Example()
        {
            var Add = (int x, int y) => x + y;
            var WriteOutput = (int x) => Console.WriteLine(x);
        }
    }
}
