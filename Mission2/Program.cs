using Mission2;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.Write("How many dice rolls would you like to simulate? ");
        
        // Prompt user for the number of dice rolls
        int numberOfRolls = int.Parse(Console.ReadLine());
        
        // Create an instance of DiceSimulator
        DiceSimulator diceSimulator = new DiceSimulator();
        
        // Simulate the dice rolls and store the results
        int[] rollResults = diceSimulator.SimulateRolls(numberOfRolls);
        
        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine($"Total number of rolls = {numberOfRolls}\n");

        // Display the results
        for (int diceSum = 2; diceSum <= 12; diceSum++)
        {
            double percentage = (rollResults[diceSum] / (double)numberOfRolls) * 100;
            Console.Write($"{diceSum}: ");
            Console.WriteLine(new string('*', (int)Math.Round(percentage)));
        }
        
        Console.WriteLine("\nThank you for using the dice throwing simulator. Goodbye!");
    }
}