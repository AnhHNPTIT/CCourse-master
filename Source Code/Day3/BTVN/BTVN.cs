using System;
using System.Collections.Generic;
using System.IO;

namespace BTVN
{
    /// <summary>
    /// This class is used to perform arthmatic operations: ReadFile, CountFoundString
    /// </summary>
    class Program
    {
        bool isFoundFile(FileInfo file)
        {
            return (!file.Exists);
        }
        /// <summary>
        /// This function is used to read a file
        /// </summary>
        /// <param name="path">The path of file</param>
        /// <returns>Returns text in file</returns>
        /// <example>
        /// <code>
        /// string path = @"test.txt";
        /// FileInfo file = new FileInfo(path);
        /// if(isFoundFile(file))
        /// {
        ///     Console.WriteLine("Not Found File!");
        /// }
        /// </code>
        /// </example>
        /// <exception cref="FileNotFoundException">Thrown when not found file</exception> 
        List<string> ReadFile(string path)
        {
            FileInfo file = new FileInfo(path);
            if (isFoundFile(file))
            {
                throw new FileNotFoundException();
            }
            StreamReader reader = file.OpenText();
            List<string> text = new List<string>();
            while (!reader.EndOfStream)
            {
                text.Add(reader.ReadLine());
            }
            reader.Close();
            reader.Dispose();
            return text;
        }
         
        int CountFoundString(List<string> text, string searchTerm)
        {
            int count = 0;
            foreach (string str in text)
            {
                string temp = (string)str.ToLowerInvariant();
                if (temp.Contains(searchTerm.ToLowerInvariant()))
                {
                    count++;
                }
            }
            return count;
        }
        static void Main(string[] args)
        {
            Program myProgram = new Program();
            string path = @"C:\Users\hoang\source\repos\Day3\BTVN\test.txt";
            List<string> text = myProgram.ReadFile(path);
            Console.WriteLine("Text in file:");
            foreach (string str in text)
            {
                Console.WriteLine(str);
            }
            Console.Write("Enter string want to search: ");
            string searchTerm = Console.ReadLine();
            int count = myProgram.CountFoundString(text, searchTerm);
            Console.WriteLine("String {0} found {1} times ", searchTerm, count);
        }
    }
}
