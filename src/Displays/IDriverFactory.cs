namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public interface IDriverFactory
{
    IDisplayDriver CreateDriver(ConsoleColor color);
}
