namespace WpfApplication1.Model
{
    /// <summary>
    /// "Настоящий сложный" элемент модели
    /// </summary>
    public class ComplexEmailSource: IEmailSource
    {
        public string GetEmail(object parameter)
        {
            // в настоящем приложении здесь будет сложная логика по получению данных, в примере просто заглушка
            var person = parameter as Person;
            if (person != null)
                return $"{person.Name}@gmail.com";
            return "";
        }
    }
}
