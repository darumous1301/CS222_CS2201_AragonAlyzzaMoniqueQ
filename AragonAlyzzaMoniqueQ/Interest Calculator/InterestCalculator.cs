using System;
namespace simpleInterest
{
   class InterestCalculator
   {
       static void Main(string[] args)
       {
           
           Console.Write("Enter principal amount: ");
           double principal = double.Parse(Console.ReadLine());
           
           Console.Write("Enter rate of interest: ");
           double rate = double.Parse(Console.ReadLine());
           
           Console.Write("Enter time in years: ");
           int time = int.Parse(Console.ReadLine());
           
           double simpleInterest = (principal * rate * time)/100;
           
           Console.WriteLine("Simple Interest: " + simpleInterest);
       }
   }
}
