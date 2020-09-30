using System.Threading.Tasks;
using RestCalculator.Algorithm.Operations;

namespace RestCalculator.Business.Interfaces
{
    public interface ICalculator
    {
        Task<double> GetResult(double num1, double num2, BaseOperation operation);
    }
}