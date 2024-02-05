using Factory.Controls.Interfaces;
using Factory.Controls.Mac;
using Factory.Factories.Interfaces;

namespace Factory.Factories;

public class MacFactory : IGUIFactory {
	public IButton CreateButton() {
		return new MacButton();
	}

	public ICheckbox CreateCheckbox() {
		return new MacCheckbox();
	}
}