using System;
using WpfApplication1.Model;

namespace UnitTestProject.Model
{
    public class EmailSenderDummy: IEmailSender
    {
        public void Send(string address, string message)
        {
            throw new NotImplementedException("It is a dummy"); 
        }
    }
}
