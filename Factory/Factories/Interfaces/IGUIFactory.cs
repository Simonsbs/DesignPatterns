using Factory.Controls.Interfaces;

namespace Factory.Factories.Interfaces;

/// <summary>
/// Defines the interface for a GUI factory. This interface is part of the Abstract Factory
/// design pattern and specifies the methods for creating abstract GUI elements, such as buttons
/// and checkboxes. Implementations of this interface will provide concrete creations of these
/// elements specific to different GUI styles or operating systems.
/// </summary>
public interface IGUIFactory {
	/// <summary>
	/// Creates a new button instance.
	/// </summary>
	/// <returns>
	/// A new instance of an object that implements the <see cref="IButton"/> interface,
	/// representing a button in the GUI.
	/// </returns>
	IButton CreateButton();

	/// <summary>
	/// Creates a new checkbox instance.
	/// </summary>
	/// <returns>
	/// A new instance of an object that implements the <see cref="ICheckbox"/> interface,
	/// representing a checkbox in the GUI.
	/// </returns>
	ICheckbox CreateCheckbox();
}
