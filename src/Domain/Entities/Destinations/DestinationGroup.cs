using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;

public class DestinationGroup : Destination
{
    private readonly ICollection<Destination> _destinations;

    public DestinationGroup(ICollection<Destination> destinations)
    {
        _destinations = destinations;
    }

    public void AddDestination(Destination destination)
    {
        _destinations.Add(destination);
    }

    public void RemoveDestination(Destination destination)
    {
        _destinations.Remove(destination);
    }

    protected override void InternalSendMessage(IMessage message)
    {
        foreach (Destination destination in _destinations)
            destination.SendMessage(message);
    }
}