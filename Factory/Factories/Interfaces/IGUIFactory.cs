using Factory.Controls.Interfaces;

namespace Factory.Factories.Interfaces;

public interface IGUIFactory {
	IButton CreateButton();
	ICheckbox CreateCheckbox();
}