using System;

namespace RollDice
{

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the dice throwing simulator!");

            // Get number of rolls from the user
            int numberofRolls;
            
            Console.Write("How many dice rolls would you like to simulate? ");
            if (!int.TryParse(Console.ReadLine(), out int numberOfRolls) || numberOfRolls <= 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                return;
            }

            // Simulate dice rolls
            DiceSimulator simulator = new DiceSimulator();
            int[] rollResults = simulator.RollDice(numberOfRolls);

            // Display results
            Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
            Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
            Console.WriteLine($"Total number of rolls = {numberOfRolls}.\n");

            for (int i = 0; i < rollResults.Length; i++)
            {
                int rollSum = i + 2; // Change index to dice sum
                double percentage = (rollResults[i] / (double)numberOfRolls) * 100;
                int starsCount = (int)Math.Round(percentage);

                Console.Write($"{rollSum}: ");
                Console.WriteLine(new string('*', starsCount)); // Print asterisks
            }

            Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
        }
    }
}