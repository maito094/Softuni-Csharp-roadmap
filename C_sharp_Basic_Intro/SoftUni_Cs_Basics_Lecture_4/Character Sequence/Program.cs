using System;

namespace Character_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            string userText = Console.ReadLine();

            for (int i = 0; i <= userText.Length - 1; i += 1)
            {
                Console.WriteLine(userText.Substring(i, 1));
            }


            for (int i = 0; i < userText.Length; i += 1)
            {
                Console.WriteLine(userText[i]);
            }
        }
    }
}
