using Factory.Controls.Interfaces;
using System; // Required for accessing Console.WriteLine

namespace Factory.Controls.Mac;

/// <summary>
/// Represents a checkbox styled for macOS. This class provides a concrete implementation
/// of the <see cref="ICheckbox"/> interface, demonstrating how a checkbox can be customized
/// to match the macOS visual style.
/// </summary>
public class MacCheckbox : ICheckbox {
	/// <summary>
	/// Renders the checkbox on the screen in a manner consistent with macOS design aesthetics.
	/// This method simulates the appearance of a macOS-styled checkbox by outputting a message
	/// to the console, acting as a stand-in for actual graphical rendering in a user interface.
	/// </summary>
	public void Paint() {
		Console.WriteLine("Render a checkbox in a macOS style");
	}
}