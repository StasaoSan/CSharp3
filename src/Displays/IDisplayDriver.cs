namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public interface IDisplayDriver
{
    ConsoleColor Color { get; set; }
    void Clear();
    void WriteText(string text);
    void SetColor(ConsoleColor color);
}