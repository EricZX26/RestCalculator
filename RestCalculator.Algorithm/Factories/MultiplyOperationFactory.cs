using RestCalculator.Algorithm.Operations;

namespace RestCalculator.Algorithm.Factories
{
    public class MultiplyOperationFactory : IOperationFactory
    {
        public BaseOperation CreateOperation()
        {
            return new MultiplyOperation();
        }
    }
}