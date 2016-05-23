using System;
using System.Windows.Input;

namespace WpfApplication1.ViewModels.Commands
{
    public delegate void ExecuteAction(object parameter);

    /// <summary>
    /// Команда. Параметризуется методом, который нужно выполнить
    /// </summary>
    public class CustomCommand: ICommand
    {
        private readonly ExecuteAction _executeAction;

        public CustomCommand(ExecuteAction executeAction)
        {
            _executeAction = executeAction;
        }

        public bool CanExecute(object parameter)
        {
            // пока можно выполнить всегда
            return true;
        }

        public void Execute(object parameter)
        {
            _executeAction(parameter);
        }

        public event EventHandler CanExecuteChanged;
    }
}
