using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;
using Itmo.ObjectOrientedProgramming.Lab3.Logging;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;

public class DestinationLogger : Destination
{
    private readonly Destination _destination;
    private readonly Logger _logger;

    public DestinationLogger(Destination destination, Logger logger)
    {
        _destination = destination ?? throw new ArgumentNullException(nameof(destination), "Destination cannot be null.");
        _logger = logger;
    }

    protected override void InternalSendMessage(IMessage message)
    {
        _destination.SendMessage(message);

        _logger.Log($"Message sent to {message.Title}.");
    }
}