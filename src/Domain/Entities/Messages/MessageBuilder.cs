using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Enums;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

public class MessageBuilder
{
    private string? _title;
    private string? _body;
    private MessageImportant _importance;
    private int _id;

    public MessageBuilder WithID(int id)
    {
        _id = id;
        return this;
    }

    public MessageBuilder WithMessageTitile(string title)
    {
        _title = title;
        return this;
    }

    public MessageBuilder WithMessageBody(string body)
    {
        _body = body;
        return this;
    }

    public MessageBuilder WithImportance(MessageImportant important)
    {
        _importance = important;
        return this;
    }

    public Message Build()
    {
        if (_title is null || _body is null)
            throw new ArgumentException("Message cant be null");
        return new Message(_id, _title, _body, _importance);
    }
}