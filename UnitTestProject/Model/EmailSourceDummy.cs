using System;
using WpfApplication1.Model;

namespace UnitTestProject.Model
{
    public class EmailSourceDummy: IEmailSource
    {
        public string GetEmail()
        {
            throw new NotImplementedException("It is test dummy");
        }
    }
}
