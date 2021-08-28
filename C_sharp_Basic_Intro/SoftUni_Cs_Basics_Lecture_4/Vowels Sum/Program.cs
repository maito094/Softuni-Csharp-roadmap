using System;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText = Console.ReadLine();
            int sumVowels = 0;
            for (int i = 0; i < userText.Length; i += 1)
            {
                if (userText[i] == 'a')       //e	i	o	u
                {
                    sumVowels += 1;
                }
                else if (userText[i] == 'e')
                {
                    sumVowels += 2;
                }
                else if (userText[i] == 'i')
                {
                    sumVowels += 3;
                }
                else if (userText[i] == 'o')
                {
                    sumVowels += 4;
                }
                else if (userText[i] == 'u')
                {
                    sumVowels += 5;
                }

            }

            Console.WriteLine(sumVowels);
        }
    }
}
