using System;
using System.IO;

namespace _03._Extract_File
{
   class Program
   {
      static void Main(string[] args)
      {
         //C:\Internal\training-internal\Template.pptx

         string fullPath = Console.ReadLine();
         var fileName2 = Path.GetFileNameWithoutExtension(fullPath);
         var extension2 = Path.GetExtension(fullPath);

         Console.WriteLine(fileName2);
         Console.WriteLine(extension2);

         int lastIndexOfBackSlash = fullPath.LastIndexOf('\\') + 1;

         string fileNameWithExtension = fullPath.Substring(lastIndexOfBackSlash);
         int extensionIndex = fileNameWithExtension.LastIndexOf('.') + 1;
         string extension = fileNameWithExtension.Substring(extensionIndex);

         fileNameWithExtension = fileNameWithExtension.Substring(0, extensionIndex - 1);
         Console.WriteLine($"File name: {fileNameWithExtension}");
         Console.WriteLine($"File extension: {extension}");
      }
   }
}
