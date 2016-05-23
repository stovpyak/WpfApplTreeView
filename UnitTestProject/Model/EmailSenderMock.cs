using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Model;

namespace UnitTestProject.Model
{
    /// <summary>
    /// Mock для тестов - запоминает то что отправляли
    /// может проверить то ли было отправлено
    /// </summary>
    public class EmailSenderMock : IEmailSender
    {
        private string _address;
        private string _message;

        public void Send(string address, string message)
        {
            _address = address;
            _message = message;
        }

        public bool Verification(string address, string message)
        {
            return ((_address == address) && (_message == message));
        }

    }
}
