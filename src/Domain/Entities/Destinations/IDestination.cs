using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;

public interface IDestination
{
    void SendMessage(IMessage message);
}