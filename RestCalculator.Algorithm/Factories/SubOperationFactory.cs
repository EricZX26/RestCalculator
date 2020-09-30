using RestCalculator.Algorithm.Operations;

namespace RestCalculator.Algorithm.Factories
{
    public class SubOperationFactory : IOperationFactory
    {
        public BaseOperation CreateOperation()
        {
            return new SubOperation();
        }
    }
}