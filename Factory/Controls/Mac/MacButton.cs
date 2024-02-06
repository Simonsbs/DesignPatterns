using Factory.Controls.Interfaces;
using System; // Necessary for Console.WriteLine

namespace Factory.Controls.Mac;

/// <summary>
/// Represents a button styled specifically for macOS.
/// This class implements the <see cref="IButton"/> interface to provide a concrete representation
/// of a button in macOS style, demonstrating how GUI elements can be customized for different operating systems.
/// </summary>
public class MacButton : IButton {
	/// <summary>
	/// Renders the button on the screen in a style that is consistent with macOS design principles.
	/// This method outputs a message to the console to simulate the appearance of a macOS-styled button,
	/// serving as a placeholder for actual rendering logic in a graphical user interface.
	/// </summary>
	public void Paint() {
		Console.WriteLine("Render a button in a macOS style.");
	}
}