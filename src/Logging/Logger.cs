namespace Itmo.ObjectOrientedProgramming.Lab3.Logging;

public class Logger
{
    private readonly List<IHandler> _handlers = new List<IHandler>();
    private readonly List<string> _logQueue = new List<string>();

    public void AddHandler(IHandler handler)
    {
        _handlers.Add(handler);
    }

    public void Log(string message)
    {
        _logQueue.Add(message);
    }

    public void FlushLogs()
    {
        foreach (string message in _logQueue)
        {
            foreach (IHandler handler in _handlers)
                handler.Log(message);
        }

        _logQueue.Clear();
    }

    public void ClearHandlers()
    {
        _handlers.Clear();
    }
}