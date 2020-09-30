using System;
using System.Threading.Tasks;

namespace RestCalculator.Algorithm.Operations
{
    public class DivideOperation : BaseOperation
    {
        public override async Task<double> Run()
        {
            if (Num2 == 0)
            {
                throw new DivideByZeroException();
            }
            double result = 0;
            await Task.Run(() => result = Num1 / Num2);
            if (double.IsInfinity(result))
            {
                throw new OverflowException();
            }

            return result;
        }
    }
}