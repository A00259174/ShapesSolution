using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

class Program
{
    static async Task Main(string[] args)
    {
        var featureManagement = new Dictionary<string, string>
        {
            { "FeatureManagement:Square", "true"},
            { "FeatureManagement:Rectangle", "false"},
            { "FeatureManagement:Triangle", "true"}
        };

        IConfigurationRoot configuration = new ConfigurationBuilder().AddInMemoryCollection(featureManagement).Build();

        static async Task Main(string[] args)
        {
            // Setup Feature Management and Dependency Injection

            // Continue with your program logic here
            Console.WriteLine("Welcome to the Shape Calculator!");

            // Display menu options
            Console.WriteLine("Select a shape:");
            Console.WriteLine("1. Square");
            Console.WriteLine("2. Rectangle");
            Console.WriteLine("3. Triangle");

            // Accept user input for shape selection
            Console.Write("Enter your choice: ");
            string userInput = Console.ReadLine();

            // Process user input
            switch (userInput)
            {
                case "1":
                    // Handle square calculation
                    double sideLength = GetUserInput("Enter the length of the side of the square: ");
                    var square = new Square(sideLength);
                    Console.WriteLine($"Area of the square: {square.CalculateArea()}");
                    Console.WriteLine($"Perimeter of the square: {square.CalculatePerimeter()}");
                    break;
                // Similar handling for other shapes
                default:
                    Console.WriteLine("Invalid choice. Please select a valid option.");
                    break;
            }
        }

        static double GetUserInput(string prompt)
        {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return double.Parse(input);
        }

    }
}
