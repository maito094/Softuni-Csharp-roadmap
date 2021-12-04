using CommandPattern.Core.Commands;
using CommandPattern.Core.Contracts;
using System;
using System.Linq;
using System.Reflection;

namespace CommandPattern.Core
{
   public class CommandInterpreter : ICommandInterpreter
   {

      public string Read(string args)
      {
         string[] inputInfo = args.Split();

         string commandName = inputInfo[0] + "Command";
         string[] parameters = inputInfo.Skip(1).ToArray();


         Type type = Assembly
            .GetCallingAssembly()
            .GetTypes()
            .Where(t => t.Name == commandName)
            .FirstOrDefault();
         if (type==null)
         {
            throw new InvalidOperationException("Invalid command");
         }

         // ICommand command = Activator.CreateInstance(type) as ICommand; return null
         ICommand command = (ICommand)Activator.CreateInstance(type); // will throw exception


         //string result = string.Empty;

         // ICommand command = null;

         //if (commandName == nameof(HelloCommand))
         //{
         //   command = new HelloCommand();
         //   //ICommand command = new HelloCommand();
         //   //result = command.Execute(parameters);

         //}
         //else if (commandName == nameof(ExitCommand))
         //{
         //   command = new ExitCommand();

         //}
         //else
         //{
         //   throw new InvalidOperationException("Invalid command");
         //}

         //result = command.Execute(parameters);
         string result = command.Execute(parameters);
         return result;


      }
   }
}
