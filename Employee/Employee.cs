class Employee
{
    // Fields for employee information
    private string lastName;
    private string firstName;

    // Constructor to initialize employee information
    public Employee(string lastName, string firstName)
    {
        this.lastName = lastName;
        this.firstName = firstName;
    }

    // Method to calculate salary and tax
    public void CalculateSalaryAndTax(string position, int experience)
    {
        double baseSalary = 0.0;

        // Define base salary based on position and experience
        switch (position.ToLower())
        {
            case "manager":
                baseSalary = 50000;
                break;
            case "developer":
                baseSalary = 60000;
                break;
            // Add more cases for other positions as needed
            default:
                Console.WriteLine("Invalid position");
                return;
        }

        // Calculate salary with experience bonus
        double totalSalary = baseSalary + (experience * 1000);

        // Calculate tax (15% of the salary)
        double tax = 0.15 * totalSalary;

        // Display employee information
        Console.WriteLine("Employee Information:");
        Console.WriteLine($"Last Name: {lastName}");
        Console.WriteLine($"First Name: {firstName}");
        Console.WriteLine($"Position: {position}");
        Console.WriteLine($"Salary: {totalSalary:C}");
        Console.WriteLine($"Tax: {tax:C}");
    }
}
