namespace Factory.Controls.Interfaces;

/// <summary>
/// Defines the interface for a button control. This interface is part of an abstract factory pattern
/// that allows for the creation of buttons with specific styles and behaviors, depending on the
/// concrete factory implementation. The button's appearance and functionality can be customized
/// for different GUI environments.
/// </summary>
public interface IButton {
	/// <summary>
	/// Renders the button on the screen. Implementations of this method should define how the button
	/// is displayed, including its visual styling according to the specific GUI system (e.g., Windows, Mac).
	/// </summary>
	void Paint();
}