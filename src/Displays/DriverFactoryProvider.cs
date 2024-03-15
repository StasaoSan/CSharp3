namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public static class DriverFactoryProvider
{
    public static IDriverFactory GetFactory(DriverType type, string? filePath = null)
    {
        return type switch
        {
            DriverType.Console => new ConsoleDriverFactory(),
            DriverType.File when !string.IsNullOrEmpty(filePath) => new FileDriverFactory(filePath),
            _ => throw new ArgumentException($"Invalid driver type or missing parameters: {type}"),
        };
    }
}