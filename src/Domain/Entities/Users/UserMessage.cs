using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Lab3.Domain.Entities.Users;

public class UserMessage
{
    public UserMessage(IMessage message)
    {
        Message = message;
        IsRead = false;
    }

    public IMessage Message { get; }
    public bool IsRead { get; private set; }

    public void MarkAsRead()
    {
        IsRead = true;
    }
}
