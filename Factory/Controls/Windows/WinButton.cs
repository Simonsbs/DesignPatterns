using Factory.Controls.Interfaces;

namespace Factory.Controls.Windows;

public class WinButton : IButton {
	public void Paint() {
		Console.WriteLine("Render a button in a Windows style");
	}
}