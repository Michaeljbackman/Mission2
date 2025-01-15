// See https://aka.ms/new-console-template for more information

// Greet the user.
// Ask for the number of dice rolls.
// Pass the input to a secondary class for simulation.
// Display the histogram based on the results.

// Use the array returned by SimulateRolls to calculate the percentage of each result.
// Print a histogram where each * represents 1% of the rolls

using Mission2; 

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate?");
        
        int rolls = int.Parse(Console.ReadLine());
        
        DiceSimulator simulator = new DiceSimulator();
        int[] results = simulator.SimulateRoll(rolls);
        
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {rolls}\n");

        for (int i = 2; i <= 12; i++)
        {
            double percentage = (results[i] / (double)rolls) * 100;
            Console.Write($"{i}: ");
            Console.WriteLine(new string ('*', (int)Math.Round(percentage)));
        }
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}