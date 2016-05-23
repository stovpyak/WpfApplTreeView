namespace WpfApplication1.Model
{
    public interface IEmailSender
    {
        void Send(string address, string message);
    }
}
