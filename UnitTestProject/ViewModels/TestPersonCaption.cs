using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Model;
using WpfApplication1.Model;
using WpfApplication1.ViewModels;

namespace UnitTestProject.ViewModels
{
    [TestClass]
    public class TestPersonCaption
    {
        [TestMethod]
        public void TestCaptionEmpty()
        {
            var emailSource = new EmailSourceStub("person@gmail.com");
            var model = new Person("Name", emailSource);
            var emailSender = new EmailSenderDummy();
            var viewModel = new PersonViewModel(model, emailSender);

            Assert.AreEqual("Name (person@gmail.com)", viewModel.Caption, "incorrect person caption");
        }
    }
}
