using System.Threading.Tasks;
using RestCalculator.Algorithm.Operations;
using RestCalculator.Business.Interfaces;

namespace RestCalculator.Business.Implements
{
    public class CalculatorService : ICalculator
    {
        public async Task<double> GetResult(double num1, double num2, BaseOperation operation)
        {
            operation.Num1 = num1;
            operation.Num2 = num2;
            double result = await operation.Run();
            return result;
        }
    }
}