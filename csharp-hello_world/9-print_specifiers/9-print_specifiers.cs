using System;

class Program
{
    static void Main(string[] args)
    {
        double percent = .7553;
        double currency = 0;
        Console.WriteLine($"Percent: {percent.ToString("P2", System.Globalization.CultureInfo.InvariantCulture)}");
        Console.WriteLine($"Currency: {currency.ToString("C2", System.Globalization.CultureInfo.GetCultureInfo("en-US"))}");
    }
}