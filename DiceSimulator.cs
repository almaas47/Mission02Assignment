namespace RollDice;

// Class for dice rolls
public class DiceSimulator
{
    private static Random random = new Random();

    // Method to roll dice and return numbers in array
    public int[] RollDice(int numberOfRolls)
    {
        int[] results = new int[11]; // Array for sums 2 to 12
            
        for (int i = 0; i < numberOfRolls; i++)
        {
            int die1 = random.Next(1, 7); // Roll first die
            int die2 = random.Next(1, 7); // Roll second die
            int sum = die1 + die2;        // Add the two dice
                
            results[sum - 2]++; // Increment index
        }

        return results;
    }
}