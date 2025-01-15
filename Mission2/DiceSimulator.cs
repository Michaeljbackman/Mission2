namespace Mission2;

// Simulate rolling two six-sided dice.
// Store the results in an array.
// Return the array to the main class.

// Create a method SimulateRolls(int rolls) that:
// Uses a Random object to generate dice rolls.
// Updates an array to track the frequency of each result (2 through 12).
// Returns the array.


public class DiceSimulator
{
    public int[] SimulateRoll(int rolls)
    {
        int[] results = new int[13];
        
        Random random = new Random();
        for (int i = 0; i < rolls; i++)
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            int sum = die1 + die2;

            results[sum]++;
        }
        return results;
    }
}