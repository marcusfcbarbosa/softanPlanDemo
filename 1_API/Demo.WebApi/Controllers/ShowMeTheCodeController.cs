using Demo.Domain.DemoContext.Commands.Output;
using Demo.Shared.Commands;
using Demo.Shared.Utils;
using Microsoft.AspNetCore.Mvc;

namespace Demo.WebApi.Controllers
{
    public class ShowMeTheCodeController : ControllerBase
    {
        [HttpGet]
        [Route("showmethecode")]
        public ICommandResult RetornaJuros()
        {
            return new CommandResult(true, "Code", Util.Code);
        }
    }
}