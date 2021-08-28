using System;

namespace DepositCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            double depositedSum = double.Parse(Console.ReadLine());
            int periodForDeposit = int.Parse(Console.ReadLine());
            double percentInterest = double.Parse(Console.ReadLine())/100;
            
            double sumFinal = depositedSum + periodForDeposit * ((depositedSum * percentInterest) / 12);
            Console.WriteLine(sumFinal);
        }
    }
}
