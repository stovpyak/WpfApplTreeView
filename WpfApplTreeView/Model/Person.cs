namespace WpfApplication1.Model
{
    public class Person
    {
        private readonly IEmailSource _emailSource;

        public Person(string name, IEmailSource emailSource)
        {
            Name = name;
            _emailSource = emailSource;
        }

        public string Name { get; private set; }

        public string Email => _emailSource.GetEmail();
    }
}
