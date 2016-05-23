using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApplication1.Model;

namespace UnitTestProject.Model
{
    public class EmailSourceStub: IEmailSource
    {
        private readonly string _email;

        public EmailSourceStub(string email)
        {
            _email = email;
        }

        public string GetEmail(object parameter)
        {
            return _email;
        }
    }
}
