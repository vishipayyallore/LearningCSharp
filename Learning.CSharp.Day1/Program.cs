using System;
using Learning.CSharp.DataModels;
using Learning.CSharp.DataRepositories;
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
                var productsRepository = new ProductsRepository();
                var product = new Product
                {
                    Name = NameGenerator.GenerateName(),
                    Price =  102.3M
                };
                productsRepository.Add(product).Wait();
            }
            catch (Exception errorObject)
            {
                Console.WriteLine("\nError: {0}", errorObject.Message);
            }
            Console.WriteLine("\n\nPress any key ...");
            Console.Read();
        }

    }

}
