using Factory.Controls.Interfaces;

namespace Factory.Controls.Mac;

public class MacButton : IButton {
	public void Paint() {
		Console.WriteLine("Render a button in a MacOS style");
	}
}