using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3Lab3.Domain.Entities;

namespace Lab3.Domain.Entities.Messengers;

public interface IMessanger : IEndPointMessage
{
    void SendMessage(IMessage message);
}