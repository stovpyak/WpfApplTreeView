using WpfApplication1.Model;

namespace WpfApplication1.ViewModels
{
    public class PersonViewModel: TreeNodeBaseViewModel
    {
        private readonly Person _person;

        public PersonViewModel(Person person)
        {
            _person = person;
        }

        public override string Caption => _person.Name;

        public override object Icon => null;
    }
}
