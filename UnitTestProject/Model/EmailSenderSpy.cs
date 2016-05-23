using System.Collections.Generic;
using WpfApplication1.Model;

namespace UnitTestProject.Model
{
    /// <summary>
    /// Spy для тестов - не отправляет сообщения, а запоминает что отправлялось
    /// кто то снаружи потом может это запомненное использовать для проверки
    /// </summary>
    public class EmailSenderSpy: IEmailSender
    {
        public void Send(string address, string message)
        {
            Mails.Add(new Mail(address, message));
        }

        public List<Mail> Mails { get; } = new List<Mail>();
    }

    public class Mail
    {
        public Mail(string address, string message)
        {
            Address = address;
            Message = message;
        }

        public string Address { get; private set; }
        public string Message { get; private set; }
    }
}
