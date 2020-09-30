using Microsoft.AspNetCore.Mvc;
using MediatR;
using Microsoft.Extensions.DependencyInjection;
namespace RestCalculator.Api.Controllers
{
    [ApiController]
    public class BaseController : ControllerBase
    {
        private IMediator _mediator;

        public IMediator Mediator => _mediator ?? (_mediator = HttpContext.RequestServices.GetService<IMediator>());
    }
}