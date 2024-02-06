using Factory.Controls.Interfaces;

namespace Factory.Controls.Windows;

/// <summary>
/// Represents a button styled specifically for Windows. This class implements the <see cref="IButton"/> interface,
/// providing a concrete representation of a button in Windows style, illustrating how GUI elements can be tailored for
/// different operating systems.
/// </summary>
public class WinButton : IButton {
	/// <summary>
	/// Renders the button on the screen in a style that is consistent with Windows design principles.
	/// This method outputs a message to the console to simulate the appearance of a Windows-styled button,
	/// serving as a placeholder for actual rendering logic in a graphical user interface.
	/// </summary>
	public void Paint() {
		Console.WriteLine("Render a button in a Windows style");
	}
}