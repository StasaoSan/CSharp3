namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class ConsoleDisplayDriver : IDisplayDriver
{
    public ConsoleDisplayDriver(ConsoleColor color)
    {
        Color = color;
    }

    public ConsoleColor Color { get; set; }

    public void Clear()
    {
        Console.Clear();
    }

    public void WriteText(string text)
    {
        Console.ForegroundColor = Color;
        Console.WriteLine(text);
        Console.ResetColor();
    }

    public void SetColor(ConsoleColor color)
    {
        Color = color;
    }
}