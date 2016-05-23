using System;
using WpfApplication1.Model;

namespace UnitTestProject.Model
{
    public class EmailSourceDummy: IEmailSource
    {
        public string GetEmail(object parameter)
        {
            throw new NotImplementedException("It is a test dummy");
        }
    }
}
