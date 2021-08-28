using System;

namespace Coins
{
   class Program
   {
      static void Main(string[] args)
      {
         const int coin_2_lv = 200;
         const int coin_1_lv = 100;
         const int coin_50_st = 50;
         const int coin_20_st = 20;
         const int coin_10_st = 10;
         const int coin_5_st = 5;
         const int coin_2_st = 2;
         const int coin_1_st = 1;

         int sumChange = Convert.ToInt32(double.Parse(Console.ReadLine()) * 100);
         int numCoins = 0;
         while (true)
         {
            if (sumChange / coin_2_lv >= 1)
            {
               sumChange -= coin_2_lv;
               numCoins++;
               continue;
            }
            if (sumChange / coin_1_lv >= 1)
            {
               sumChange -= coin_1_lv;
               numCoins++;
               continue;
            }
            if (sumChange / coin_50_st >= 1)
            {
               sumChange -= coin_50_st;
               numCoins++;
               continue;
            }
            if (sumChange / coin_20_st >= 1)
            {
               sumChange -= coin_20_st;
               numCoins++;
               continue;
            }
            if (sumChange / coin_10_st >= 1)
            {
               sumChange -= coin_10_st;
               numCoins++;
               continue;
            }
            if (sumChange / coin_5_st >= 1)
            {
               sumChange -= coin_5_st;
               numCoins++;
               continue;
            }
            if (sumChange / coin_2_st >= 1)
            {
               sumChange -= coin_2_st;
               numCoins++;
               continue;
            }
            if (sumChange / coin_1_st >= 1)
            {
               sumChange -= coin_1_st;
               numCoins++;
               continue;
            }

            break;

         }
         Console.WriteLine(numCoins);
      }
   }
}
