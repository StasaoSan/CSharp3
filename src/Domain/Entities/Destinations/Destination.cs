using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;

public abstract class Destination : IDestination
{
    public void SendMessage(IMessage message)
    {
        InternalSendMessage(message);
    }

    protected abstract void InternalSendMessage(IMessage message);
}