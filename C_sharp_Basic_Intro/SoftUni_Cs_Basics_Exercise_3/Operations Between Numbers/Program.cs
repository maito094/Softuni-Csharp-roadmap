using System;

namespace Operations_Between_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1 = int.Parse(Console.ReadLine());
            int n2 = int.Parse(Console.ReadLine());
            char op = char.Parse(Console.ReadLine());
            double result = 0;
            string numberIs = "";

            switch (op)
            {
                case '+':
                    result = n1 + n2;
                    if (result %2==0)
                    {
                        numberIs = "even";
                    }
                    else
                    {
                        numberIs = "odd";
                    }

                    Console.WriteLine($"{n1} {op} {n2} = {result} - {numberIs}");
                    break;
                case '-':
                    result = n1 - n2;
                    if (result % 2 == 0)
                    {
                        numberIs = "even";
                    }
                    else
                    {
                        numberIs = "odd";
                    }

                    Console.WriteLine($"{n1} {op} {n2} = {result} - {numberIs}");
                    break;
                case '*':
                    result = n1 * n2;
                    if (result % 2 == 0)
                    {
                        numberIs = "even";
                    }
                    else
                    {
                        numberIs = "odd";
                    }

                    Console.WriteLine($"{n1} {op} {n2} = {result} - {numberIs}");
                    break;
                case '/':
                    
                    if (n2!=0)
                    {
                        result = (n1 * 1.00 / n2);
                        Console.WriteLine($"{n1} / {n2} = {result:0.00}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }

                    break;
                case '%':
                    if (n2 != 0)
                    {
                        result = n1 % n2;
                        Console.WriteLine($"{n1} % {n2} = {result}");
                    }
                    else
                    {
                        Console.WriteLine($"Cannot divide {n1} by zero");
                    }
      
                    break;

                default:
                    break;
            }
            
        }
    }
}
