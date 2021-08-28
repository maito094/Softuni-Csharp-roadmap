using System;

namespace Left_and_Right_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numLeftSum = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;
            int sum = 0;
            for (int i = 0; i < numLeftSum * 2; i++)
            {
                int num = int.Parse(Console.ReadLine());
                if (i < numLeftSum)
                {
                    leftSum += num;
                }
                else
                {
                    rightSum += num;
                }

            }
            if (leftSum == rightSum)
            {
                sum = leftSum;
                Console.WriteLine("Yes, sum = " + sum);
            }
            else
            {
                sum = Math.Abs(leftSum - rightSum);

                Console.WriteLine("No, diff = " + sum);
            }


        }
    }
}
