namespace Mission2
{
    // Simulate rolling two six-sided dice.
    // Store the results in an array.
    // Return the array to the main class.

    public class DiceSimulator
    {
        public int[] SimulateRolls(int numberOfRolls)
        {
            // Array to store frequency counts for each sum (2 to 12)
            int[] rollResults = new int[13]; 

            Random randomGenerator = new Random();  // Random number generator for dice rolls
            for (int rollIndex = 0; rollIndex < numberOfRolls; rollIndex++)
            {
                int die1 = randomGenerator.Next(1, 7); 
                int die2 = randomGenerator.Next(1, 7); 
                int sumOfDice = die1 + die2;            // Sum of the two dice rolls

                rollResults[sumOfDice]++; // Increment
            }
            return rollResults;
        }
    }
}