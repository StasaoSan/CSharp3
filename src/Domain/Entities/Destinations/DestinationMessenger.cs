using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Lab3.Domain.Entities.Messengers;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;

public class DestinationMessenger : Destination
{
    private readonly IMessanger _messanger;

    public DestinationMessenger(IMessanger messanger)
    {
        _messanger = messanger;
    }

    protected override void InternalSendMessage(IMessage message)
    {
        _messanger.ReceiveMessage(message);
    }
}
