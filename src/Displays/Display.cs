namespace Itmo.ObjectOrientedProgramming.Lab3.Displays;

public class Display
{
    private readonly IDisplayDriver _displayDriver;
    public Display(IDisplayDriver displayDriver)
    {
        _displayDriver = displayDriver;
    }

    public void Show(string text)
    {
        _displayDriver.Clear();
        _displayDriver.WriteText(text);
    }
}
