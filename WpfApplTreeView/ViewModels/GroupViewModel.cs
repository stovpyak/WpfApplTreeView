using System.Collections.ObjectModel;
using System.Collections.Specialized;
using WpfApplication1.Model;

namespace WpfApplication1.ViewModels
{
    public class GroupViewModel: TreeNodeBaseViewModel
    {
        private readonly PersonGroup _groupModel;
        private readonly ObservableCollection<MenuItemViewModel> _commands;
        private readonly ReadOnlyObservableCollection<MenuItemViewModel> _readOnlyCommands;

        public GroupViewModel(PersonGroup group)
        {
            _commands = new ObservableCollection<MenuItemViewModel>();
            _readOnlyCommands = new ReadOnlyObservableCollection<MenuItemViewModel>(_commands);

            _groupModel = group;
            _groupModel.Persons.CollectionChanged += Persons_Changed;
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
                var personViewModel = new PersonViewModel(person);
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
                _commands.Add(new MenuItemViewModel("Clear all", new CustomCommand("Execute clear")));
        }

        public override string Caption => _groupModel.Name;

        public override object Icon => null;

        protected override ReadOnlyObservableCollection<MenuItemViewModel> GetCommands() => _readOnlyCommands;
    }
}
