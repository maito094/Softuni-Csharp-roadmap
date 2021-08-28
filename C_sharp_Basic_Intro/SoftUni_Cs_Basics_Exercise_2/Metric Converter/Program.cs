using System;

namespace Metric_Converter
{
    class Program
    {
        static void Main(string[] args)
        {
            // mm=1000, cm=100, m=1
            double number =double.Parse( Console.ReadLine());
            string unitOfMeasureFrom = Console.ReadLine();
            string unitOfMeasureTo = Console.ReadLine();


            double ratio = 0;


            if (unitOfMeasureFrom == unitOfMeasureTo)
            {
                ratio = 1;
              
            }
            else if (unitOfMeasureFrom == "m" && unitOfMeasureTo=="cm")
            {
                ratio = 100;
            }
           else if (unitOfMeasureFrom == "m" && unitOfMeasureTo=="mm")
            {
                ratio = 1000;
            }
           else if (unitOfMeasureFrom == "mm" && unitOfMeasureTo=="cm")
            {
                ratio = 0.1;
            }
           else if (unitOfMeasureFrom == "mm" && unitOfMeasureTo=="m")
            {
                ratio = 0.001;
            }
           else if (unitOfMeasureFrom == "cm" && unitOfMeasureTo=="mm")
            {
                ratio = 10;
            }
           else if (unitOfMeasureFrom == "cm" && unitOfMeasureTo=="m")
            {
                ratio = 0.01;
            }

            Console.WriteLine("{0:F3}", number*ratio);
        }
    }
}
