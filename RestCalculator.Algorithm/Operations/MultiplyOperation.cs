using System;
using System.Threading.Tasks;

namespace RestCalculator.Algorithm.Operations
{
    public class MultiplyOperation : BaseOperation
    {
        public override async Task<double> Run()
        {
            double result = 0;
            await Task.Run(() => result = Num1 * Num2);
            if (double.IsInfinity(result))
            {
                throw new OverflowException();
            }

            return result;
        }
    }
}