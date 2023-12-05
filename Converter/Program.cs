using System;

class Program
{
    static void Main()
    {
        // Creating an instance of the Converter class with exchange rates
        Converter currencyConverter = new Converter(27.0, 33.0, 7.5); // Example rates, you can use actual rates

        // Converting from UAH to USD
        double amountInUah = 1000;
        double amountInUsd = currencyConverter.ConvertToCurrency(amountInUah, "usd");
        Console.WriteLine($"{amountInUah} UAH is approximately {amountInUsd:F2} USD");

        // Converting from USD to UAH
        double amountInUsdToUah = currencyConverter.ConvertFromCurrency(50, "usd");
        Console.WriteLine($"50 USD is approximately {amountInUsdToUah:F2} UAH");

        Console.ReadLine(); // Pause to see the output
    }
}
