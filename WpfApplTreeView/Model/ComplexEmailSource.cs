namespace WpfApplication1.Model
{
    /// <summary>
    /// "Настоящий сложный" элемент модели
    /// </summary>
    public class ComplexEmailSource: IEmailSource
    {
        public string GetEmail()
        {
            // в настоящем приложении здесь будет сложная логика по получению данных
            return "";
        }
    }
}
