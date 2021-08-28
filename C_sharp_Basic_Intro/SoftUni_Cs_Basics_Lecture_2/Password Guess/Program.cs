using System;

namespace Password_Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            string secretPassword = "s3cr3t!P@ssw0rd";
           string userPassword= Console.ReadLine();
            bool isPassCorrect = secretPassword == userPassword;
            if (!isPassCorrect)
            {
                Console.WriteLine("Wrong password!");
            }
            else
            {
                Console.WriteLine("Welcome");
            }

           
        }
    }
}
