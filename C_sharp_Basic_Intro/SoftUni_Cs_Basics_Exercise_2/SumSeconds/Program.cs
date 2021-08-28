using System;

namespace SumSeconds
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int timePlayer1= int.Parse(Console.ReadLine());
            int timePlayer2= int.Parse(Console.ReadLine());
            int timePlayer3= int.Parse(Console.ReadLine());
            int sumPlayers = timePlayer1 + timePlayer2 + timePlayer3;
            int remainedSeconds = sumPlayers % 60; // Returns The Remainder  
            int minutes = sumPlayers / 60 ;     
            
            Console.WriteLine($"{minutes}:{remainedSeconds:00}");
        }
    }
}
