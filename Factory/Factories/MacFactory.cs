using Factory.Controls.Interfaces;
using Factory.Controls.Mac;
using Factory.Factories.Interfaces;

namespace Factory.Factories;

/// <summary>
/// Represents a factory for creating Mac-specific GUI elements. Implements the <see cref="IGUIFactory"/> interface
/// to provide concrete instances of Mac buttons and checkboxes. This class demonstrates the Abstract Factory
/// design pattern by encapsulating the creation logic for GUI elements that are styled for the Mac operating system.
/// </summary>
public class MacFactory : IGUIFactory {
	/// <summary>
	/// Creates a new instance of a Mac-styled button.
	/// </summary>
	/// <returns>
	/// A new instance of <see cref="MacButton"/>, representing a button styled for the Mac operating system.
	/// </returns>
	public IButton CreateButton() {
		return new MacButton();
	}

	/// <summary>
	/// Creates a new instance of a Mac-styled checkbox.
	/// </summary>
	/// <returns>
	/// A new instance of <see cref="MacCheckbox"/>, representing a checkbox styled for the Mac operating system.
	/// </returns>
	public ICheckbox CreateCheckbox() {
		return new MacCheckbox();
	}
}