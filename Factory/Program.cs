using Factory.Factories;
using Factory.Factories.Interfaces;

namespace Factory;

/// <summary>
/// Program class that serves as the main entry point for the Factory application.
/// This program demonstrates the Abstract Factory design pattern by allowing users
/// to create GUI elements for different operating systems (Mac or Windows) based on their choice.
/// </summary>
class Program {
	/// <summary>
	/// Main entry point for the application. It continuously prompts the user
	/// to choose a type of GUI factory (Mac or Windows) and creates the corresponding
	/// GUI elements until the user decides to exit.
	/// </summary>
	/// <param name="args">Command-line arguments. Not used in this application.</param>
	static void Main(string[] args) {
		// Loop until the user chooses to exit.
		while (true) {
			Console.WriteLine("----------------------------------------------");
			Console.WriteLine("Choose the GUI factory type:");
			Console.WriteLine("1: 'Mac'");
			Console.WriteLine("2: 'Windows'");
			Console.WriteLine("0: 'Exit'");
			Console.Write("Selection: ");
			string userInput = Console.ReadLine();

			// Create the factory based on the user's input.
			IGUIFactory factory;
			switch (userInput.Trim().ToLower()) {
				case "mac":
				case "m":
				case "1":
					factory = new MacFactory();
					break;
				case "windows":
				case "w":
				case "2":
					factory = new WinFactory();
					break;
				case "exit":
				case "e":
				case "0":
					Console.WriteLine("Exiting application.");
					return;
				default:
					Console.WriteLine("Invalid selection, please try again.");
					continue;
			}

			Console.WriteLine("----------------------------------------------");

			// Create the application with the chosen factory and paint the GUI.
			var app = new Application(factory);
			app.Paint();
		}
	}
}