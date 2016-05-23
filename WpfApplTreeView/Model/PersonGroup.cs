using System.Collections.ObjectModel;

namespace WpfApplication1.Model
{
    public class PersonGroup
    {
        public PersonGroup(string name)
        {
            Name = name;
        }

        public string Name { get; private set; }

        public ObservableCollection<Person> Persons { get; } = new ObservableCollection<Person>();
    }
}
