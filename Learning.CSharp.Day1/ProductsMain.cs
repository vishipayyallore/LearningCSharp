using System;
using Learning.CSharp.Day1.Sample1;

namespace Learning.CSharp.Day1
{
    class ProductsMain
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            try
            {
                var prodcutsDemo1 = new ProdcutsDemo1();
                prodcutsDemo1
                    .GenerateProducts()
                    .SortAndDisplayProducts(new ProductNameComparer())
                    .SortAndDisplayProducts(new ProductPriceComparer())
                    .GenerateProducts(x => x.Price > 2000.0M && x.Price<3000.0M)
                    .SortAndDisplayProducts(new ProductNameComparer())
                    .SortAndDisplayProducts(new ProductPriceComparer())
                    .GenerateProducts(x => x.Price > 2500.0M && x.Price < 3000.0M)
                    .SortAndDisplayProducts(new ProductNameComparer())
                    .SortAndDisplayProducts(new ProductPriceComparer())
                    .GenerateProducts(x => x.Price > 2800.0M && x.Price < 3000.0M)
                    .SortAndDisplayProducts(new ProductNameComparer())
                    .SortAndDisplayProducts(new ProductPriceComparer());
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
