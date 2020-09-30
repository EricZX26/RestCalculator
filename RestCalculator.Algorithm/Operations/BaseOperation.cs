using System.Threading.Tasks;

namespace RestCalculator.Algorithm.Operations
{
    public abstract class BaseOperation
    {
        public double Num1 { get; set; }
        public double Num2 { get; set; }
        //Assume it's async 
        public abstract Task<double> Run();

    }
}