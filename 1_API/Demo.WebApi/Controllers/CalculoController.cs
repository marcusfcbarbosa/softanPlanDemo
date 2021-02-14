using System.Threading.Tasks;
using Demo.Domain.DemoContext.Commands.Input;
using Demo.Domain.DemoContext.Handlers;
using Demo.Shared.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CalculoController : ControllerBase
    {
        [HttpPost]
        [Route("")]
        public async Task<ICommandResult> Create([FromServices] IMediator mediator,
        [FromBody] ValuesCommand command)
        {
            return await  mediator.Send(command);
        }
    }
}