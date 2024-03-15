namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class ConsoleDriverFactory : IDriverFactory
{
    public IDisplayDriver CreateDriver(ConsoleColor color)
    {
        return new ConsoleDisplayDriver(color);
    }
}
