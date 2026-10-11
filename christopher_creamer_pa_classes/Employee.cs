/*******************************************************************
* Name: Christopher Creamer
* Date: October 11, 2026
* Assignment: SDC220 Performance Assessment - Classes
*
* Description:
* Represents an Employee with first name, last name, and monthly salary.
* Includes validation requiring monthly salary to be >= 1000.
*******************************************************************/
public class Employee
{
    // Public properties
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public double MonthlySalary { get; private set; }

    // Public constructor initializing all properties
    public Employee(string firstName, string lastName, double monthlySalary)
    {
        FirstName = firstName;
        LastName = lastName;

        // Set monthly salary only if >= 1000; defaults to 0.0 otherwise
        if (monthlySalary >= 1000.0)
        {
            MonthlySalary = monthlySalary;
        }
    }

    // Method to update Monthly Salary with validation
    public void SetMonthlySalary(double monthlySalary)
    {
        if (monthlySalary >= 1000.0)
        {
            MonthlySalary = monthlySalary;
        }
    }
}