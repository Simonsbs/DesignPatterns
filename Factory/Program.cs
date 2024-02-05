using Factory.Factories;
using Factory.Factories.Interfaces;
using System;

namespace Factory {

	class Program {
		static void Main(string[] args) {
			while (true) {
				Console.WriteLine("----------------------------------------------");
				Console.WriteLine("Choose the GUI factory type:");
				Console.WriteLine("1: 'Mac'");
				Console.WriteLine("2: 'Windows'");
				Console.WriteLine("0: 'Exit'");
				string userInput = "" + Console.ReadLine();

				IGUIFactory factory;
				switch (userInput.ToLower()) {
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
					case "0":
						return;
					default:
						Console.WriteLine("Invalid selection, please try again.");
						continue;
				}

				Console.WriteLine("----------------------------------------------");
				var app = new Application(factory);
				app.Paint();
			}
		}
	}
}