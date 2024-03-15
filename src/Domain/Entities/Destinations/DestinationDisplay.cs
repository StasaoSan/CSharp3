using Itmo.ObjectOrientedProgramming.Lab3.Displays;
using Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Messages;

namespace Itmo.ObjectOrientedProgramming.Lab3.Domain.Entities.Destinations;

public class DestinationDisplay : Destination
{
    private readonly Display _display;

    public DestinationDisplay(Display display)
    {
        _display = display;
    }

    protected override void InternalSendMessage(IMessage message)
    {
        string text = $"Title: {message.Title}\nBody: {message.Body}";
        _display.Show(text);
    }
}