using System.Threading.Tasks;
using Demo.Domain.DemoContext.Commands.Input;
using Demo.Domain.DemoContext.Commands.Output;
using Demo.Domain.DemoContext.Handlers;
using Demo.Shared.Commands;
using Demo.Shared.Utils;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApi.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class CalculoController : ControllerBase
    {
        private readonly CalculoJurosHandler _calculoJurosHandler;
        public CalculoController(CalculoJurosHandler calculoJurosHandler)
        {
            _calculoJurosHandler = calculoJurosHandler;
        }

        [HttpPost]
        [Route("calculajuros")]
        public ICommandResult Calcula([FromBody] ValuesCommand command)
        {
            return _calculoJurosHandler.Handle(command);
        }

        [HttpGet]
        [Route("taxajuros")]
        public ICommandResult RetornaJuros()
        {
            return new CommandResult(true, "Taxa Juros", Util.Juros);
        }
    }
}