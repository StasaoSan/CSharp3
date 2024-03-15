namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class FileDisplayDriver : IDisplayDriver
{
    private readonly string _filePath;

    public FileDisplayDriver(string filePath, ConsoleColor color)
    {
        _filePath = filePath;
        Color = color;
    }

    public ConsoleColor Color { get; set; }

    public void SetColor(ConsoleColor color)
    {
        Color = color;
    }

    public void Clear()
    {
        File.WriteAllText(_filePath, string.Empty);
    }

    public void WriteText(string text)
    {
        string formattedText = $"{Color}: {text}";
        File.WriteAllText(_filePath, formattedText);
    }
}