namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class DisplayBuilder
{
    private IDisplayDriver? _driver;

    public DisplayBuilder WithDriver(IDisplayDriver displayDriver)
    {
        _driver = displayDriver;
        return this;
    }

    public Display Build()
    {
        if (_driver is null)
            throw new ArgumentException("Message cant be null");
        return new Display(_driver);
    }
}