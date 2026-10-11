/*******************************************************************
* Name: Christopher Creamer
* Date: October 11, 2026
* Assignment: SDC220 Performance Assessment - Classes
*
* Description:
* Main application entry point. Instantiates Employee objects,
* displays initial data, updates names and salaries, and displays
* the updated values formatted to match specifications.
*******************************************************************/
public class Program
{
    static void Main(string[] args)
    {
        // Header line
        Console.WriteLine("Christopher Creamer - Week 1 PA Classes\n");

        // Instantiate two employees (one with invalid salary < 1000)
        Employee emp1 = new Employee("John", "Jones", 0.00);
        Employee emp2 = new Employee("Jane", "Jamison", 2500.00);

        // Display initial employee details
        Console.WriteLine("Initial information for each employee");
        Console.WriteLine("Name: {0} {1}", emp1.FirstName, emp1.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}\n", emp1.MonthlySalary);

        Console.WriteLine("Name: {0} {1}", emp2.FirstName, emp2.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}\n", emp2.MonthlySalary);

        // Update employee details per specifications:
        // Update last name of one employee
        emp1.LastName = "Smith";

        // Update first name of other employee
        emp2.FirstName = "Janey";

        // Update salary of both employees
        emp1.SetMonthlySalary(1500.00);
        emp2.SetMonthlySalary(2750.00);

        // Display updated employee details
        Console.WriteLine("Updated information for each employee");
        Console.WriteLine("Name: {0} {1}", emp1.FirstName, emp1.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}\n", emp1.MonthlySalary);

        Console.WriteLine("Name: {0} {1}", emp2.FirstName, emp2.LastName);
        Console.WriteLine("Monthly Salary: ${0:F2}", emp2.MonthlySalary);
    }
}