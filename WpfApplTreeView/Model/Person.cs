using System.Collections.ObjectModel;

namespace WpfApplication1.Model
{
    public class Person
    {
        
        public Person(string name)
        {
            Name = name;
        }

        public string Name { get; private set; } 
    }
}
