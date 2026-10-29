/*******************************************************************
* Name: Christopher Creamer
* Date: October 29, 2026
* Assignment: SDC220 Performance Assessment - User Entry of Age
*
* Description:
* Main application class. Prompts the user to enter their age, 
* validates that the input is an integer within the range of 1 to 100,
* and handles FormatException and ArgumentOutOfRangeException accordingly.
*******************************************************************/
public class UserAgeEntry
{
    static void Main(string[] args)
    {
        // Print header line
        Console.WriteLine("Christopher Creamer - Week 4 PA User Entry of Age\n");

        bool isValid = false;

        while (!isValid)
        {
            try
            {
                Console.Write("Please enter your age: ");
                string? input = Console.ReadLine();
                int age = Convert.ToInt32(input);

                // Check if age is within valid range
                if (age < 1 || age > 100)
                {
                    throw new ArgumentOutOfRangeException("age", "Specified argument was out of the range of valid values.");
                }

                // If valid, display age and exit loop
                Console.WriteLine("The age entered is: {0}", age);
                isValid = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0}", e);
                Console.WriteLine("Please enter an integer in range 1 - 100.\n");
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine("{0}", e);
                Console.WriteLine("Please enter an integer in range 1 - 100.\n");
            }
        }
    }
}