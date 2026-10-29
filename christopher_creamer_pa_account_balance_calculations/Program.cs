/*******************************************************************
* Name: Christopher Creamer
* Date: October 29, 2026
* Assignment: SDC220 Performance Assessment - Account Balance Calculations
*
* Description:
* Main application class. Manages a bank account balance, allowing 
* the user to enter credits and debits. Throws a user-defined exception 
* if a transaction results in a negative balance and handles format 
* exceptions for invalid entries.
*******************************************************************/
public class AccountBalance
{
    public static double GetValue(double currentBalance)
    {
        Console.Write("Please enter a credit or debit amount (0 to quit): ");
        string? input = Console.ReadLine();
        double amount = Convert.ToDouble(input);

        if ((currentBalance + amount) < 0)
        {
            throw new Exception("Amount entered would cause the account to be negative.");
        }

        return amount;
    }

    static void Main(string[] args)
    {
        // Print header line
        Console.WriteLine("Christopher Creamer - Week 4 PA Account Balance Calculations\n");

        double balance = 0.0;
        bool startingValid = false;

        while (!startingValid)
        {
            try
            {
                Console.Write("Please enter the starting balance: ");
                string? input = Console.ReadLine();
                balance = Convert.ToDouble(input);
                startingValid = true;
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0}", e);
                Console.WriteLine("Please enter a numeric value.\n");
            }
        }

        bool running = true;

        while (running)
        {
            try
            {
                double amount = GetValue(balance);

                if (amount == 0)
                {
                    running = false;
                }
                else
                {
                    balance += amount;
                    Console.WriteLine("The updated balance is: {0:F2}\n", balance);
                }
            }
            catch (FormatException e)
            {
                Console.WriteLine("{0}", e);
                Console.WriteLine("Please enter a numeric value.\n");
            }
            catch (Exception e)
            {
                Console.WriteLine("{0}", e);
                Console.WriteLine("Please enter a numeric value.\n");
            }
        }
    }
}