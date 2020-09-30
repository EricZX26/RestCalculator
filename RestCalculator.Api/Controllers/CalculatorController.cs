using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RestCalculator.Algorithm.Factories;
using RestCalculator.Business.Interfaces;
using RestCalculator.Business.Queries;

namespace RestCalculator.Api.Controllers
{
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]/[action]")]
    public class CalculatorController : BaseController
    {

        [HttpGet]
        public async Task<double> Add([FromQuery] double num1, [FromQuery] double num2)
        {
            BinaryOperations.Query query = new BinaryOperations.Query()
            {
                Num1 = num1,
                Num2 = num2,
                factory = new AddOperationFactory()
            };

            return await Mediator.Send(query);
        }
    }
}