using Factory.Controls.Interfaces;

namespace Factory.Controls.Windows;

public class WinCheckbox : ICheckbox {
	public void Paint() {
		Console.WriteLine("Render a checkbox in a Windows style");
	}
}