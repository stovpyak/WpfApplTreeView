using System.Collections.ObjectModel;
using WpfApplication1.Model;
using WpfApplication1.ViewModels.Commands;

namespace WpfApplication1.ViewModels
{
    public class PersonViewModel: TreeNodeBaseViewModel
    {
        private readonly Person _person;
        private readonly IEmailSender _emailSender;

        public PersonViewModel(Person person, IEmailSender emailSender)
        {
            _person = person;
            _emailSender = emailSender;
        }

        protected override ReadOnlyObservableCollection<MenuItemViewModel> GetCommands()
        {
            var commands = new ObservableCollection<MenuItemViewModel>();
            if (_person.Email != "")
            {
                commands.Add(new MenuItemViewModel("Отправить email", new CustomCommand(SendEmail)));
            }
            return new ReadOnlyObservableCollection<MenuItemViewModel>(commands);
        }

        private void SendEmail(object parameter)
        {
            var message = parameter as string;
            _emailSender.Send(_person.Email, message);
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
