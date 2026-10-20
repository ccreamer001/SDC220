/*******************************************************************
* Name: Christopher Creamer
* Date: October 19, 2026
* Assignment: SDC220 Performance Assessment - Smallest Number
*
* Description:
* Main application class. Prompts the user to specify a quantity of 
* integers to enter, reads each integer in a loop, determines the 
* smallest value entered, and outputs the result.
*******************************************************************/
public class Program
{
    static void Main(string[] args)
    {
        // Print header line
        Console.WriteLine("Christopher Creamer - Week 2 PA Smallest Number\n");

        Console.WriteLine("Finding the Smallest Value:");
        Console.Write("How many integers would you like to enter: ");
        string? input = Console.ReadLine();
        int count = Convert.ToInt32(input);

        int smallest = 0;

        for (int i = 0; i < count; i++)
        {
            Console.Write("Enter an integer value: ");
            input = Console.ReadLine();
            int currentVal = Convert.ToInt32(input);

            // First time through the loop, set smallest to the first entered value
            if (i == 0)
            {
                smallest = currentVal;
            }
            // Subsequent iterations, check if current value is smaller
            else if (currentVal < smallest)
            {
                smallest = currentVal;
            }
        }

        Console.WriteLine("The smallest value entered is: {0}", smallest);
    }
}