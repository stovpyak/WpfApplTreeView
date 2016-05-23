using System.Collections.ObjectModel;
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

        protected override ReadOnlyObservableCollection<MenuItemViewModel> GetCommands()
        {
            var commands = new ObservableCollection<MenuItemViewModel>();
            if (_person.Email != "")
            {
                commands.Add(new MenuItemViewModel("Отправить email", new CustomCommand($"send email to {_person.Email}")));
            }
            return new ReadOnlyObservableCollection<MenuItemViewModel>(commands);
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
