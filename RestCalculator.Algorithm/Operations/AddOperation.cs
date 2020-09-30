using System;
using System.Threading.Tasks;

namespace RestCalculator.Algorithm.Operations
{
    public class AddOperation : BaseOperation
    {
        public override async Task<double> Run()
        {
            double result = Num1 + Num2;
            if (double.IsInfinity(result))
            {
                throw new OverflowException();
            }

            return result;
        }
    }
}