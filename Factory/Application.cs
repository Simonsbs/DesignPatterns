using Factory.Controls.Interfaces;
using Factory.Factories.Interfaces;

namespace Factory;

public class Application(IGUIFactory factory) {
	private readonly IButton _button = factory.CreateButton();
	private readonly ICheckbox _checkbox = factory.CreateCheckbox();

	public void Paint() {
		_button.Paint();
		_checkbox.Paint();
	}
}