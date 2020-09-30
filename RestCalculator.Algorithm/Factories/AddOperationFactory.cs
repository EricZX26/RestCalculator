using RestCalculator.Algorithm.Operations;

namespace RestCalculator.Algorithm.Factories
{
    public class AddOperationFactory : IOperationFactory
    {
        public BaseOperation CreateOperation()
        {
            return new AddOperation();
        }
    }
}