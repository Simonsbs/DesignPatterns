using Factory.Controls.Interfaces;

namespace Factory.Controls.Mac;

public class MacCheckbox : ICheckbox
{
    public void Paint()
    {
        Console.WriteLine("Render a checkbox in a MacOS style");
    }
}