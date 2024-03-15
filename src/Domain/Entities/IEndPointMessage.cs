using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3Lab3.Domain.Entities;

public interface IEndPointMessage
{
    void ReceiveMessage(IMessage message);
}
