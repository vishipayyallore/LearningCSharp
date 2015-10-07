using System;
using Learning.CSharp.Utilities;

namespace Learning.CSharp.Day1
{
    class Program
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                Console.WriteLine(NameGenerator.GenerateName());
            }
            catch (Exception)
            {
                
                throw;
            }
            Console.WriteLine("\n\nPress any key ...");
            Console.Read();
        }

    }

}
