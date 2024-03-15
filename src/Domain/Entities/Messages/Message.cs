using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

public class Message : IMessage
{
    public Message(int id, string title, string body, MessageImportant importance)
    {
        Id = id;

        Title = title;
        Body = body;
        Importance = importance;
    }

    public string Title { get; private set; }
    public string Body { get; private set; }
    public MessageImportant Importance { get; private set; }
    public int Id { get; }
}