using System;
using System.Windows;
using System.Windows.Input;

namespace WpfApplication1.ViewModels
{
    /// <summary>
    /// Команда для демонстрации того, что привязки отработали правильно
    /// </summary>
    public class CustomCommand: ICommand
    {
        private readonly string _msg;

        public CustomCommand(string msg)
        {
            _msg = msg;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            MessageBox.Show($"Custom Command Executed {_msg}");
        }

        public event EventHandler CanExecuteChanged;
    }
}
