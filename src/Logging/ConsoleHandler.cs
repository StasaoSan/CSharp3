using Itmo.ObjectOrientedProgramming.Lab3.Displays;

namespace Itmo.ObjectOrientedProgramming.Lab3.Logging;

public class ConsoleHandler : IHandler
{
    private readonly IDisplayDriver _console;

    public ConsoleHandler(IDisplayDriver console)
    {
        _console = console;
    }

    public void Log(string message)
    {
        _console.WriteText($"[LOG]: {message}");
    }
}
