using Factory.Controls.Interfaces;
using Factory.Controls.Windows;
using Factory.Factories.Interfaces;

namespace Factory.Factories;

/// <summary>
/// Represents a factory for creating Windows-specific GUI elements. Implements the <see cref="IGUIFactory"/> interface
/// to provide concrete instances of Windows buttons and checkboxes. This class demonstrates the Abstract Factory
/// design pattern by encapsulating the creation logic for GUI elements that are styled for the Windows operating system.
/// </summary>
public class WinFactory : IGUIFactory {
	/// <summary>
	/// Creates a new instance of a Windows-styled button.
	/// </summary>
	/// <returns>
	/// A new instance of <see cref="WinButton"/>, representing a button styled for the Windows operating system.
	/// </returns>
	public IButton CreateButton() {
		return new WinButton();
	}

	/// <summary>
	/// Creates a new instance of a Windows-styled checkbox.
	/// </summary>
	/// <returns>
	/// A new instance of <see cref="WinCheckbox"/>, representing a checkbox styled for the Windows operating system.
	/// </returns>
	public ICheckbox CreateCheckbox() {
		return new WinCheckbox();
	}
}