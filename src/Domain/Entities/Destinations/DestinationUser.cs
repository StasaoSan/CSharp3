using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Users;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;

public class DestinationUser : Destination
{
    public DestinationUser(IUser user)
    {
        User = user;
    }

    public IUser User { get; }

    protected override void InternalSendMessage(IMessage message)
    {
        User.ReceiveMessage(message);
    }
}
