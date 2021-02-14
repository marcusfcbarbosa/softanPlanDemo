
using Demo.Shared.Commands;
using FluentValidator;
using FluentValidator.Validation;


namespace Demo.Domain.DemoContext.Commands.Input
{

    public class ValuesCommand : Notifiable, ICommand
    {

        public decimal valorInicial {get;set;}
        public int meses {get;set;}
        public void Validate()
        {
            AddNotifications(new ValidationContract()
                 .Requires()
                 .IsGreaterThan(valorInicial,0, "valorInicial", "valorInicial deve ser maior que Zero")
                 .IsGreaterThan(meses,0, "meses", "meses deve ser maior que Zero")
             );
        }
    }
}