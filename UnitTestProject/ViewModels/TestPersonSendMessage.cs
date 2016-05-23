using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Model;
using WpfApplication1.Model;
using WpfApplication1.ViewModels;

namespace UnitTestProject.ViewModels
{
    [TestClass]
    public class TestPersonSendMessage
    {
        [TestMethod]
        public void TestSimpleWithSpy()
        {
            const string email = "person@gmail.com";
            const string message = "It is a message";

            var emailSource = new EmailSourceStub(email);
            var model = new Person("Name", emailSource);
            var emailSender = new EmailSenderSpy();
            var viewModel = new PersonViewModel(model, emailSender);

            var sendCommand = viewModel.Commands.First();
            sendCommand.Command.Execute(message);

            Assert.AreEqual(1, emailSender.Mails.Count, "incorrect mails");
            var mail = emailSender.Mails.First();
            Assert.AreEqual(email, mail.Address, "incorrect address");
            Assert.AreEqual(message, mail.Message, "incorrect message");
        }

        [TestMethod]
        public void TestSimpleWithMock()
        {
            const string email = "person@gmail.com";
            const string message = "It is a message";

            var emailSource = new EmailSourceStub(email);
            var model = new Person("Name", emailSource);
            var emailSender = new EmailSenderMock();
            var viewModel = new PersonViewModel(model, emailSender);

            var sendCommand = viewModel.Commands.First();
            sendCommand.Command.Execute(message);

            Assert.IsTrue(emailSender.Verification(email, message), "incorrect mail");
        }
    }
}
