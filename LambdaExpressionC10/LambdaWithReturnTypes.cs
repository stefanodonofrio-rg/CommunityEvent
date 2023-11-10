namespace LambdaExpressionC10
{
    internal class LambdaWithReturnTypes
    {
        public void Example()
        {
            var executor = IOperationExecutor (OperationType operationType) => operationType == OperationType.Sum ? new SumExecutor() : new SubExecutor();
            var operationExecutor = executor(OperationType.Sum);
            var result = operationExecutor.Execute(1, 2);
        }
    }


    interface IOperationExecutor
    {
        int Execute(int firstOperand, int secondOperand);
    }

    enum OperationType
    {
        Sum,
        Sub
    }

    class SumExecutor : IOperationExecutor
    {
        public int Execute(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }

    class SubExecutor : IOperationExecutor
    {
        public int Execute(int firstOperand, int secondOperand)
        {
            return firstOperand + secondOperand;
        }
    }
}
