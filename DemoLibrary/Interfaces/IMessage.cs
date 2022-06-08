namespace DemoLibrary
{
    public interface IMessage
    {
        void SendMessage(IPerson person, string message);
    }
}