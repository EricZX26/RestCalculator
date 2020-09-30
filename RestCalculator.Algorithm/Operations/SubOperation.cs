using System;
using System.Threading.Tasks;

namespace RestCalculator.Algorithm.Operations
{
    public class SubOperation : BaseOperation
    {
        public override async Task<double> Run()
        {
            Double result = 0;
            await Task.Run(() => result = Num1 - Num2);
            if (double.IsInfinity(result))
            {
                throw new OverflowException();
            }

            return result;
        }
    }
}