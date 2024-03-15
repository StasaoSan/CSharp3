using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Topics;

public class Topic : ITopic
{
    public Topic(string title, Destination destination)
    {
        Title = title ?? throw new ArgumentNullException(nameof(title));
        Destination = destination ?? throw new ArgumentNullException(nameof(destination));
    }

    public string Title { get; }

    public Destination Destination { get; }

    public void SendMessage(IMessage message)
    {
        Destination.SendMessage(message);
    }
}