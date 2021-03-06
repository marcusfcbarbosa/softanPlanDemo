using System;
using System.Threading;
using System.Threading.Tasks;
using Demo.Domain.DemoContext.Commands.Input;
using Demo.Domain.DemoContext.Commands.Output;
using Demo.Shared.Commands;
using Demo.Shared.Utils;
using FluentValidator;
using MediatR;

namespace Demo.Domain.DemoContext.Handlers
{
    public class CalculoJurosHandler 
    : Notifiable,
    ICommandHandler<ValuesCommand>
    {
        public ICommandResult Handle(ValuesCommand request)
        {
            request.Validate();
            if(!request.Valid){
                    return new CommandResult(true, "Erros", request.Notifications);
            }
            var valorfinal = request.valorInicial * Math.Pow((1 + Util.Juros), request.meses);
            return new CommandResult(true, "Valor Final", valorfinal);
        }
    }
}