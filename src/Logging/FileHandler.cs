namespace Itmo.ObjectOrientedProgramming.Lab3.Logging;

public class FileHandler : IHandler
{
    private readonly string _filePath;

    public FileHandler(string filePath)
    {
        _filePath = filePath;
    }

    public void Log(string message)
    {
        File.AppendAllText(_filePath, $"[LOG]: {message}\n");
    }
}