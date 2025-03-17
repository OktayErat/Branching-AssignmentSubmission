using System;

class Program
{
    static void Main(string[] args)
    {
        // Display welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Get package weight from user
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if package is too heavy (over 50 pounds)
        if (weight > 50)
        {
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return; // End program if package is too heavy
        }

        // Get package dimensions from user
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Calculate total dimensions
        double totalDimensions = width + height + length;

        // Check if package is too big (dimensions total over 50)
        if (totalDimensions > 50)
        {
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return; // End program if package is too big
        }

        // Calculate shipping quote:
        // 1. Multiply dimensions (width * height * length)
        // 2. Multiply by weight
        // 3. Divide by 100 to get final quote
        double quote = (width * height * length * weight) / 100;

        // Display the shipping quote formatted as currency
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");
        Console.WriteLine("Thank you!");
    }
} 