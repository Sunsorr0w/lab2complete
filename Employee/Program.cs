using System;

class Program
{
    static void Main()
    {
        // Creating an instance of the Employee class
        Employee employee = new Employee("Doe", "John");

        // Calculating salary and tax for the employee
        employee.CalculateSalaryAndTax("manager", 5);

        Console.ReadLine(); // Pause to see the output
    }
}
