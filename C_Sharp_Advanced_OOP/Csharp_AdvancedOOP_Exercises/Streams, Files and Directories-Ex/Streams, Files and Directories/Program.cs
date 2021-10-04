using System;
using System.Collections.Generic;
using System.IO;
using System.IO.Compression;
using System.Linq;

namespace Streams__Files_and_Directories
{
   class Program
   {
      static void Main(string[] args)
      {
         //EvenLines();
         //LineNumbers();
         //WordCount();
         //CopyBinaryFile();
         //DirectoryTraversal();
         //ZipAndExtract();
      }

      private static void ZipAndExtract()
      {
         string sourceDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\mySourceFolder";
         string targetDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\copyMeArhive.zip";
         string destinationDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\copyMeFolder";
         ZipFile.CreateFromDirectory(sourceDirectory, targetDirectory);
         ZipFile.ExtractToDirectory(targetDirectory, destinationDirectory);
      }

      private static void DirectoryTraversal()
      {
         string[] allFiles = Directory.GetFiles(@"../../../", ".");

         Dictionary<string, Dictionary<string, double>> groupedFiles = new Dictionary<string, Dictionary<string, double>>();

         foreach (var file in allFiles)
         {
            FileInfo fileInfo = new FileInfo(file);
            string fileName = fileInfo.Name;
            string fileExtension = fileInfo.Extension;
            double fileSizeKB = fileInfo.Length / 1024.0;

            if (!groupedFiles.ContainsKey(fileExtension))
            {
               groupedFiles.Add(fileExtension, new Dictionary<string, double>());
            }
            groupedFiles[fileExtension].Add(fileName, fileSizeKB);
         }

         groupedFiles = groupedFiles
            .OrderByDescending(o => o.Value.Count())
            .ThenBy(a => a.Key)
            .ToDictionary(k => k.Key, v => v.Value);

         List<string> lines = new List<string>();

         foreach (var extension in groupedFiles)
         {
            lines.Add(extension.Key);
            foreach (var file in extension.Value.OrderBy(x => x.Value))
            {
               lines.Add($"--{file.Key} - {file.Value:F3}kb");
            }
         }

         string pathDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "\\report.txt";
         File.WriteAllLines(pathDesktop, lines);
      }

      private static void CopyBinaryFile()
      {
         FileStream fileReader = new FileStream("copyMe.png", FileMode.Open);
         FileStream fileWrite = new FileStream("copyMeCopy.png", FileMode.Create);

         byte[] arrayofBytes = new byte[256];

         while (true)
         {
            int currentBytes = fileReader.Read(arrayofBytes, 0, arrayofBytes.Length);

            if (currentBytes == 0)
            {
               break;
            }
            fileWrite.Write(arrayofBytes, 0, currentBytes);


         }

         fileWrite.Close();
      }

      private static void WordCount()
      {
         Dictionary<string, int> wordsCount = new Dictionary<string, int>();

         string[] wordsLine = File.ReadAllLines("words.txt");

         string[] textLines = File.ReadAllLines("text.txt");

         foreach (var words in wordsLine)
         {
            if (!wordsCount.ContainsKey(words.ToLower()))
            {
               wordsCount.Add(words, 0);
            }
         }

         foreach (var line in textLines)
         {
            foreach (var key in wordsCount.Keys)
            {
               if (line.Contains(key, StringComparison.OrdinalIgnoreCase))
               {
                  wordsCount[key]++;
               }
            }

         }

         foreach (var item in wordsCount.OrderByDescending(x => x.Value))
         {
            string result = $"{item.Key} - {item.Value}{Environment.NewLine}";
            File.AppendAllText("actualResult.txt", result);
         }
      }

      private static void LineNumbers()
      {
         string[] lines = File.ReadAllLines("text.txt");
         List<string> listOfString = new List<string>();

         for (int i = 0; i < lines.Length; i++)
         {
            int letterCount = lines[i].Count(symbol => char.IsLetter(symbol));
            int punctuationCount = lines[i].Count(symbol => char.IsPunctuation(symbol));

            listOfString.Add($"Line {i + 1}: {lines[i]} ({letterCount})({punctuationCount})");

            File.WriteAllLines("output.txt", listOfString);
         }
      }

      private static void EvenLines()
      {
         StreamReader streamReader = new StreamReader("text.txt");
         bool isEven = true;

         string[] specialSymbols = new[] { "-", ",", ".", "!", "?" };

         while (true)
         {
            string result = streamReader.ReadLine();
            if (result == null)
            {
               break;
            }
            if (!isEven)
            {
               isEven = true;
               continue;
            }

            foreach (var symbol in specialSymbols)
            {
               result = result.Replace(symbol, "@");
            }

            Console.WriteLine(string.Join(" ", result.Split(" ").Reverse()));

            isEven = false;
         }

         streamReader.Close();
      }
   }
}
