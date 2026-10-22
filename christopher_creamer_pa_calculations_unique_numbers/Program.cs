/*******************************************************************
* Name: Christopher Creamer
* Date: October 22, 2026
* Assignment: SDC220 Performance Assessment - Calculations & Unique Numbers
*
* Description:
* Main application class. Collects 10 integer values into an array,
* extracts unique values into a List, and utilizes overloaded methods 
* to calculate and display counts, sums, and averages.
*******************************************************************/
using System.Collections.Generic;

public class Program
{
    static void Main(string[] args)
    {
        // Print header line
        Console.WriteLine("Christopher Creamer - Week 3 PA Calculations & Unique Numbers\n");

        // Declare array for 10 integers
        int[] intArray = new int[10];
        List<int> uniqueList = new List<int>();

        // Get 10 integer values from the user and store in array
        for (int i = 0; i < intArray.Length; i++)
        {
            Console.Write("Please enter an integer value: ");
            string? input = Console.ReadLine();
            int val = Convert.ToInt32(input);
            intArray[i] = val;

            // Store unique numbers in a List
            if (!uniqueList.Contains(val))
            {
                uniqueList.Add(val);
            }
        }

        Console.WriteLine();

        // Calculate totals using overloaded methods
        int arraySum = CalculateSum(intArray);
        int listSum = CalculateSum(uniqueList);

        double arrayAvg = (double)arraySum / intArray.Length;
        double listAvg = (double)listSum / uniqueList.Count;

        // Display array statistics
        Console.WriteLine("The count of integers entered is: {0}", intArray.Length);
        Console.WriteLine("The sum of integers entered is: {0}", arraySum);
        Console.WriteLine("The average of integers entered is: {0}\n", arrayAvg);

        // Display unique list statistics
        Console.WriteLine("The count of unique integers entered is: {0}", uniqueList.Count);
        Console.WriteLine("The sum of unique integers entered is: {0}", listSum);
        Console.WriteLine("The average of unique integers entered is: {0}", listAvg);
    }

    // Method to calculate sum of integers in an array
    public static int CalculateSum(int[] arr)
    {
        int total = 0;
        foreach (int num in arr)
        {
            total += num;
        }
        return total;
    }

    // Overloaded method to calculate sum of integers in a List
    public static int CalculateSum(List<int> list)
    {
        int total = 0;
        foreach (int num in list)
        {
            total += num;
        }
        return total;
    }
}