using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Filters;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations.Filters;

public class DestinationProxyFilter : IDestination
{
    private readonly IDestination _realDestination;
    private readonly ICollection<BaseFilter> _filters;

    public DestinationProxyFilter(IDestination realDestination, ICollection<BaseFilter> filters)
    {
        _realDestination = realDestination ?? throw new ArgumentNullException(nameof(realDestination), "Real destination cannot be null.");
        _filters = filters ?? throw new ArgumentNullException(nameof(filters), "Filters cannot be null.");
    }

    public void SendMessage(IMessage message)
    {
        if (_filters.All(filter => filter.Check(message)))
        {
            _realDestination.SendMessage(message);
        }
    }
}