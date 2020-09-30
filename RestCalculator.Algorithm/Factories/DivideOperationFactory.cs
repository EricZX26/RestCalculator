using RestCalculator.Algorithm.Operations;

namespace RestCalculator.Algorithm.Factories
{
    public class DivideOperationFactory : IOperationFactory
    {
        public BaseOperation CreateOperation()
        {
            return new DivideOperation();
        }
    }
}