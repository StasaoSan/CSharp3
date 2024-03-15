namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class FileDriverFactory : IDriverFactory
{
    private readonly string _filePath;

    public FileDriverFactory(string filePath)
    {
        _filePath = filePath;
    }

    public IDisplayDriver CreateDriver(ConsoleColor color)
    {
        return new FileDisplayDriver(_filePath, color);
    }
}