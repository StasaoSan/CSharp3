using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Topics;

public interface ITopic
{
    public string Title { get; }
    public Destination Destination { get; }
    public void SendMessage(IMessage message);
}