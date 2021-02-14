using Demo.Domain.DemoContext.Commands.Input;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Demo.Test.CommandTests
{
    [TestClass]
    public class CreateValuesCommandTest
    {
        private readonly ValuesCommand _invalidCommand = new ValuesCommand(10,5);
        private readonly ValuesCommand _validCommand = new ValuesCommand(0,0);
        public CreateValuesCommandTest()
        {
            _invalidCommand.Validate();
            _validCommand.Validate();
        }
        
        //RED GREEN REFACTOR
        [TestMethod]
        public void DadoCommandoInvalido()
        {
            Assert.AreEqual(_invalidCommand.Valid, false);
        }

        [TestMethod]
        public void DadoCommandovalido()
        {
            Assert.AreEqual(_validCommand.Valid, true);
        }
    }
}