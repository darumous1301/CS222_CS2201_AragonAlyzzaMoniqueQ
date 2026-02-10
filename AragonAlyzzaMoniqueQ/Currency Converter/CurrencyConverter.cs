using System;
namespace amountInEur
{
   class CurrencyConverter
   {
       static void Main(string[] args)
       {
           
           Console.Write("Enter amount in USD: ");
           double usd = double.Parse(Console.ReadLine());
           
           Console.Write("Enter exchange rate from USD to EUR: ");
           double rate = double.Parse(Console.ReadLine());
           
           double amountInEur = usd * rate;
           
           Console.WriteLine("Amount in EUR: {0:F2}", amountInEur);
       }
   }
}
