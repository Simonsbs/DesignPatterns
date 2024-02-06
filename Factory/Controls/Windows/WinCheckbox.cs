using Factory.Controls.Interfaces;
using System; // Necessary for Console.WriteLine

namespace Factory.Controls.Windows;

/// <summary>
/// Represents a checkbox styled for Windows. This class provides a concrete implementation
/// of the <see cref="ICheckbox"/> interface, illustrating how a checkbox can be adapted
/// to fit the Windows visual style.
/// </summary>
public class WinCheckbox : ICheckbox {
	/// <summary>
	/// Renders the checkbox on the screen in a manner consistent with Windows design aesthetics.
	/// This method simulates the appearance of a Windows-styled checkbox by outputting a message
	/// to the console, acting as a stand-in for actual graphical rendering in a user interface.
	/// </summary>
	public void Paint() {
		Console.WriteLine("Render a checkbox in a Windows style");
	}
}