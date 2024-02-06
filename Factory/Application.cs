using Factory.Controls.Interfaces;
using Factory.Factories.Interfaces;

namespace Factory;

/// <summary>
/// Represents an application that can create and manage GUI elements.
/// This class demonstrates the use of the Abstract Factory design pattern
/// to abstract the creation of GUI elements (buttons, checkboxes) that are specific
/// to different operating systems.
/// </summary>
public class Application {
	private readonly IButton _button;
	private readonly ICheckbox _checkbox;

	/// <summary>
	/// Initializes a new instance of the <see cref="Application"/> class using the provided GUI factory.
	/// </summary>
	/// <param name="factory">The factory to use for creating the GUI elements.</param>
	public Application(IGUIFactory factory) {
		_button = factory.CreateButton();
		_checkbox = factory.CreateCheckbox();
	}

	/// <summary>
	/// Paints the GUI elements. This method demonstrates how the created GUI elements
	/// can be used, showcasing the abstraction provided by the factory.
	/// </summary>
	public void Paint() {
		_button.Paint();
		_checkbox.Paint();
	}
}