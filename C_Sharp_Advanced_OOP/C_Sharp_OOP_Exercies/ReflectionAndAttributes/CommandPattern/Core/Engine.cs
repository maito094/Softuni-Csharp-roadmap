using CommandPattern.Core.Contracts;
using System;


namespace CommandPattern.Core
{
   public class Engine : IEngine
   {
      private readonly ICommandInterpreter commandIntrepreter;

      public Engine(ICommandInterpreter commandIntrepreter)
      {
         this.commandIntrepreter = commandIntrepreter;
      }

      public void Run()
      {
         while (true)
         {

            try
            {
               string input = Console.ReadLine();

               string result = this.commandIntrepreter.Read(input);

               Console.WriteLine(result);
            }
            catch (Exception ex)
            {

               Console.WriteLine(ex.Message);
            }
         }

      }

   }
}
