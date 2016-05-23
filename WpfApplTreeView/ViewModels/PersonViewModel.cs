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

        public override string Caption
        {
            get
            {
                var email = _person.Email;
                if (email != "")
                    return $"{_person.Name} ({email})";
                return _person.Name;
            }
        }

        public override object Icon => null;
    }
}
