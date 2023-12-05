class Converter
{
    // Fields for exchange rates
    private double usdRate;
    private double eurRate;
    private double plnRate;

    // Custom constructor to initialize exchange rates
    public Converter(double usd, double eur, double pln)
    {
        usdRate = usd;
        eurRate = eur;
        plnRate = pln;
    }

    // Method to convert from UAH to specified currency
    public double ConvertToCurrency(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount / usdRate;
            case "eur":
                return amount / eurRate;
            case "pln":
                return amount / plnRate;
            default:
                Console.WriteLine("Invalid currency code");
                return 0.0;
        }
    }

    // Method to convert from specified currency to UAH
    public double ConvertFromCurrency(double amount, string currency)
    {
        switch (currency.ToLower())
        {
            case "usd":
                return amount * usdRate;
            case "eur":
                return amount * eurRate;
            case "pln":
                return amount * plnRate;
            default:
                Console.WriteLine("Invalid currency code");
                return 0.0;
        }
    }
}