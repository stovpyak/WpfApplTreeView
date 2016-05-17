using System.Windows.Input;

namespace WpfApplication1.ViewModels
{
    public class MenuItemViewModel
    {
        public MenuItemViewModel(string header, ICommand command)
        {
            Header = header;
            Command = command;
        }

        public string Header { get; set; }

        public ICommand Command { get; set; }
    }
}
