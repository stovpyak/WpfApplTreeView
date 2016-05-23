using Microsoft.VisualStudio.TestTools.UnitTesting;
using UnitTestProject.Model;
using WpfApplication1.Model;
using WpfApplication1.ViewModels;

namespace UnitTestProject.ViewModels
{
    [TestClass]
    public class TestPersonGroupCommands
    {
        [TestMethod]
        public void TestGroupWithoutPersons()
        {
            var model = new PersonGroup("Group");
            var viewModel = new PersonGroupViewModel(model);
            Assert.AreEqual(0, viewModel.Commands.Count, "incorrect commands count");
        }

        [TestMethod]
        public void TestGroupWithOnePerson()
        {
            var model = new PersonGroup("Group");
            var emailSource = new EmailSourceDummy();
            var person = new Person("Person", emailSource);
            model.Persons.Add(person);
            
            var viewModel = new PersonGroupViewModel(model);
            Assert.AreEqual(1, viewModel.Commands.Count, "incorrect commands count");
        }
    }
}
