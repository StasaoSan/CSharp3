using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Lab3.Domain.Entities.Messengers;

public class ConsoleMessanger : IMessanger
{
    public void SendMessage(IMessage message)
    {
        Console.WriteLine($"[Messenger]\nTitle: {message.Title}, Body: {message.Body}");
    }

    public void ReceiveMessage(IMessage message)
    {
        SendMessage(message);
    }
}