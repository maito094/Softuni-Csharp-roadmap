using System;

namespace Fruit_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            string fruit = Console.ReadLine();
            string dayOfWeek = Console.ReadLine();
            double quantity = double.Parse(Console.ReadLine());
            bool isWeekend=false;
            bool isInvalidDay = false;
            bool isInvalidFruit = false;
            double price = 0;

            if (dayOfWeek == "Monday" || dayOfWeek == "Tuesday" || dayOfWeek == "Wednesday" || dayOfWeek == "Thursday" || dayOfWeek == "Friday")
            {
                isWeekend = false;
            }
            else if (dayOfWeek == "Saturday" || dayOfWeek == "Sunday")
            {
                isWeekend=true;
            }

            else  
            {
                isInvalidDay = true;
                
            }

            switch (fruit)
            {
                case "banana":
                    if (isWeekend)
                    {
                        price = 2.70;
                    }
                    else
                    {
                        price = 2.50;
                    }
                break;
                case "apple":
                    if (isWeekend)
                    {
                        price = 1.25;
                    }
                    else
                    {
                        price = 1.2;
                    }
                    break;
                case "orange":
                    if (isWeekend)
                    {
                        price = 0.90;
                    }
                    else
                    {
                        price = 0.85;
                    }
                    break;
                case "grapefruit":
                    if (isWeekend)
                    {
                        price = 1.60;
                    }
                    else
                    {
                        price = 1.45;
                    }
                    break;
                case "kiwi":
                    if (isWeekend)
                    {
                        price = 3.0;
                    }
                    else
                    {
                        price = 2.70;
                    }
                    break;
                case "pineapple":
                    if (isWeekend)
                    {
                        price = 5.60;
                    }
                    else
                    {
                        price = 5.50;
                    }
                    break;
                case "grapes":
                    if (isWeekend)
                    {
                        price = 4.20;
                    }
                    else
                    {
                        price = 3.85;
                    }
                    break;

                default:
                    isInvalidFruit = true;
                    
                break;
            }
            if (!isInvalidDay && !isInvalidFruit)
            {
                Console.WriteLine("{0:F2}", Math.Round(quantity * price, 2));
            }
            else if (isInvalidDay || isInvalidFruit)
            {
                Console.WriteLine("error");
            }


        }
    }
}
