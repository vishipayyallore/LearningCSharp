using System;
using Learning.CSharp.DataModels;
using Learning.CSharp.DataRepositories;
using Learning.CSharp.MongoDbDataStore;
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
                var startTime = DateTime.UtcNow;
                var productsRepository = new ProductsRepository();

                for (var iCtr = 0; iCtr <= 10000; iCtr++)
                {
                    var product = new Product
                    {
                        Name = NameGenerator.GenerateName(),
                        Price = 102.3M
                    };
                    Console.WriteLine("{0}. Creating new Product {1}", iCtr, product.Name);
                    productsRepository.Add(product).Wait();
                }
                Console.WriteLine("{0} : {1}", startTime, DateTime.UtcNow);
                //Console.WriteLine(NameGenerator.GenerateName());
                
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
