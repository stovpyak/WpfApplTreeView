using Microsoft.VisualStudio.TestTools.UnitTesting;
using WpfApplication1.Model;
using WpfApplication1.ViewModels;

namespace UnitTestProject.ViewModels
{
    [TestClass]
    public class TestPersonGroup
    {
        [TestMethod]
        public void TestCommandsEmpty()
        {
            var model = new PersonGroup("Group");
            var viewModel = new GroupViewModel(model);
            Assert.AreEqual(0, viewModel.Commands.Count, "incorrect commands count");
        }

        [TestMethod]
        public void TestCommands()
        {
            var model = new PersonGroup("Group");
            var person = new Person("Person");
            model.Persons.Add(person);
            
            var viewModel = new GroupViewModel(model);
            Assert.AreEqual(1, viewModel.Commands.Count, "incorrect commands count");
        }
    }
}
