using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;
using Lab3.Domain.Entities.Users;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Users;

public class User : IUser
{
    private readonly List<UserMessage> _messages = new List<UserMessage>();
    private readonly Logger _logger;

    public User(string name, string surname, Logger logger)
    {
        Name = name;
        Surname = surname;
        _logger = logger;
    }

    public string Name { get; }
    public string Surname { get; }

    public void ReadMessage(int id)
    {
        UserMessage? userMessage = _messages.Find(t => t.Message.Id == id) ??
                                   throw new AggregateException("Incorrect message id");
        if (userMessage.IsRead)
        {
            throw new AggregateException("This message already read");
        }

        userMessage.MarkAsRead();
        _logger.Log($"User {Name} {Surname} read message with ID: {id}");
    }

    public void ReceiveMessage(IMessage message)
    {
        _messages.Add(new UserMessage(message));
        _logger.Log($"User {Name} {Surname} received message with ID: {message.Id}");
    }

    public bool IsMessageRead(int id)
    {
        UserMessage? userMessage = _messages.Find(t => t.Message.Id == id);
        if (userMessage != null) return userMessage.IsRead;
        throw new AggregateException("Message with given id not found.");
    }
}