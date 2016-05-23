using System.Collections.ObjectModel;

namespace WpfApplication1.ViewModels
{
    public class TreeNodeViewModel: TreeNodeBaseViewModel
    {
        public TreeNodeViewModel(string caption) 
        {
            Caption = caption;
        }

        public override string Caption { get; }

        public override object Icon
        {
            get { return null; }
        }

        private ObservableCollection<MenuItemViewModel> _commands;

        public void AddCommand(MenuItemViewModel item)
        {
            if (_commands == null)
                _commands = new ObservableCollection<MenuItemViewModel>();
            _commands.Add(item);
        }

        protected override ReadOnlyObservableCollection<MenuItemViewModel> GetCommands()
        {
            if (_commands != null)
                return new ReadOnlyObservableCollection<MenuItemViewModel>(_commands);
            return new ReadOnlyObservableCollection<MenuItemViewModel>(new ObservableCollection<MenuItemViewModel>());
        }
    }
}
