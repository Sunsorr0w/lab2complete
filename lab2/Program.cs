using System;


class Program
{
    static void Main()
    {
        // Creating an instance of the Address class
        Address myAddress = new Address();

        // Setting values for the address fields
        myAddress.Index = "12345";
        myAddress.Country = "Ukraine";
        myAddress.City = "Kyiv";
        myAddress.Street = "Main Street";
        myAddress.House = "42";
        myAddress.Apartment = "10";

        // Displaying the values of the address fields
        Console.WriteLine("Postal Address:");
        Console.WriteLine($"Index: {myAddress.Index}");
        Console.WriteLine($"Country: {myAddress.Country}");
        Console.WriteLine($"City: {myAddress.City}");
        Console.WriteLine($"Street: {myAddress.Street}");
        Console.WriteLine($"House: {myAddress.House}");
        Console.WriteLine($"Apartment: {myAddress.Apartment}");

        Console.ReadLine(); // Pause to see the output
    }
}
