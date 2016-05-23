using System.Collections.ObjectModel;
using System.Collections.Specialized;
using WpfApplication1.Model;
using WpfApplication1.ViewModels.Commands;

namespace WpfApplication1.ViewModels
{
    public class PersonGroupViewModel: TreeNodeBaseViewModel
    {
        private readonly PersonGroup _groupModel;
        private readonly IEmailSender _emailSender;

        private readonly ObservableCollection<MenuItemViewModel> _commands;
        private readonly ReadOnlyObservableCollection<MenuItemViewModel> _readOnlyCommands;

        public PersonGroupViewModel(PersonGroup group, IEmailSender emailSender)
        {
            _commands = new ObservableCollection<MenuItemViewModel>();
            _readOnlyCommands = new ReadOnlyObservableCollection<MenuItemViewModel>(_commands);

            _groupModel = group;
            _groupModel.Persons.CollectionChanged += Persons_Changed;
            _emailSender = emailSender;
            Update();
        }

        private void Persons_Changed(object sender, NotifyCollectionChangedEventArgs e)
        {
            Update();
        }

        private void Update()
        {
            Children.Clear();
            foreach (var person in _groupModel.Persons)
            {
                var personViewModel = new PersonViewModel(person, _emailSender);
                Children.Add(personViewModel);
            }
            UpdateCommands();
        }

        /// <summary>
        /// Каждый узел может сам формировать список команд в зависимости от бизнес логики
        /// </summary>
        private void UpdateCommands()
        {
            _commands.Clear();
            if (_groupModel.Persons.Count > 0)
                _commands.Add(new MenuItemViewModel("Clear all", new ShowMessageCommand("Execute clear")));
        }

        public override string Caption => _groupModel.Name;

        public override object Icon => null;

        protected override ReadOnlyObservableCollection<MenuItemViewModel> GetCommands() => _readOnlyCommands;
    }
}
