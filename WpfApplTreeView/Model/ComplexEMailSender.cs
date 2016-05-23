using System.Windows;

namespace WpfApplication1.Model
{
    public class ComplexEmailSender: IEmailSender
    {
        public void Send(string address, string message)
        {
            // в настоящем приложении здесь логика по отправке почты
            MessageBox.Show($"Send message: {message} to {address}");
        }
    }
}
