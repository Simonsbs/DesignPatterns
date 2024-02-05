using Factory.Controls.Interfaces;
using Factory.Controls.Windows;
using Factory.Factories.Interfaces;

namespace Factory.Factories;

public class WinFactory : IGUIFactory {
	public IButton CreateButton() {
		return new WinButton();
	}

	public ICheckbox CreateCheckbox() {
		return new WinCheckbox();
	}
}