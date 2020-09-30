using RestCalculator.Algorithm.Operations;

namespace RestCalculator.Algorithm.Factories
{
    public interface IOperationFactory
    {
        BaseOperation CreateOperation();
    }
}