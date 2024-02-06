namespace Factory.Controls.Interfaces;

/// <summary>
/// Defines the interface for a checkbox control. This interface is integral to an abstract factory pattern,
/// enabling the creation of checkboxes that are stylized and behave consistently with a specific GUI theme or operating system.
/// The design allows for customization across different platforms, such as Windows, Mac, or others, ensuring that
/// the checkbox adheres to the expected look and feel of each environment.
/// </summary>
public interface ICheckbox {
	/// <summary>
	/// Renders the checkbox on the screen. Implementations should ensure that the visual representation
	/// of the checkbox aligns with the styling norms of the target GUI system. This includes aspects like
	/// size, color, and interaction feedback.
	/// </summary>
	void Paint();
}