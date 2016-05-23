using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication1.ViewModels.Commands
{
    /// <summary>
    /// Команда для демонстрации того, что команда была вызвана
    /// </summary>
    public class ShowMessageCommand: ICommand
    {
        private readonly string _msg;

        public ShowMessageCommand(string msg)
        {
            _msg = msg;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show($"Command Executed {_msg}");
        }

        public event EventHandler CanExecuteChanged;
    }
}
