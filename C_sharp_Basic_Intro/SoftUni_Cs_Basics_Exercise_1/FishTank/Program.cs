using System;

namespace FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int lenghtTank = int.Parse(Console.ReadLine());  // Convert to decimeters
            int heightTank = int.Parse(Console.ReadLine());
            int widthTank = int.Parse(Console.ReadLine());
            double percentTaken = double.Parse(Console.ReadLine()) * 0.01;

            double litersTank = (lenghtTank * heightTank * widthTank)*0.001;
            litersTank = litersTank - litersTank * percentTaken;
        
            Console.WriteLine(string.Format("{0:0.00000}",litersTank));
        }
    }
}
