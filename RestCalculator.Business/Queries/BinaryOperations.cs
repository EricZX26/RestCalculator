using System.Threading;
using System.Threading.Tasks;
using MediatR;
using RestCalculator.Algorithm.Factories;
using RestCalculator.Algorithm.Operations;
using RestCalculator.Business.Interfaces;

namespace RestCalculator.Business.Queries
{
    public class BinaryOperations
    {
        public class Query : IRequest<double>
        {
            public double Num1 { get; set; }
            public double Num2 { get; set; }
            public IOperationFactory factory { get; set; }
        }
        public class Handler : IRequestHandler<Query, double>
        {
            private readonly ICalculator _calculator;

            public Handler(ICalculator calculator)
            {
                _calculator = calculator;
            }

            public async Task<double> Handle(Query request, CancellationToken cancellationToken)
            {
                BaseOperation oper = request.factory.CreateOperation();
                double result = await _calculator.GetResult(request.Num1, request.Num2, oper);
                return result;
            }
        }

    }
}