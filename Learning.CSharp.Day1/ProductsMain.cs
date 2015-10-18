using System;
using Learning.CSharp.DataModels;
using Learning.CSharp.Day1.Infrastructure;
using Learning.CSharp.Day1.Samples;

namespace Learning.CSharp.Day1
{
    class ProductsMain
    {
        static void Main()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Func<Product, bool> expression1 = x => x.Price > 2000.0M && x.Price < 3000.0M;
            Func<Product, bool> expression2 = x => x.Price > 2500.0M && x.Price < 3000.0M;
            Func<Product, bool> expression3 = x => x.Price > 2800.0M && x.Price < 3000.0M;

            try
            {
                var prodcutsDemo1 = new ProdcutsDemo1();
                RunProductsDemo1(prodcutsDemo1);
                RunProductsDemo1(prodcutsDemo1, expression1);
                RunProductsDemo1(prodcutsDemo1, expression2);
                RunProductsDemo1(prodcutsDemo1, expression3);

                var prodcutsDemo2 = new ProdcutsDemo2();
                RunProductsDemo2(prodcutsDemo2);
                RunProductsDemo2(prodcutsDemo2, expression1);
                RunProductsDemo2(prodcutsDemo2, expression2);
                RunProductsDemo2(prodcutsDemo2, expression3);
            }
            catch (Exception errorObject)
            {
                Console.WriteLine("\nError: {0}", errorObject.Message);
            }
            Console.WriteLine("\n\nPress any key ...");
            Console.Read();
        }

        private static void RunProductsDemo1(ProdcutsDemo1 prodcutsDemo1, Func<Product, bool> action = null)
        {
            if (action != null)
            {
                prodcutsDemo1.GenerateProducts(action)
                    .SortAndDisplayProducts(new ProductNameComparer())
                    .SortAndDisplayProducts(new ProductPriceComparer());
            }
            else
            {
                prodcutsDemo1
                    .GenerateProducts()
                    .SortAndDisplayProducts(new ProductNameComparer())
                    .SortAndDisplayProducts(new ProductPriceComparer());
            }
        }

        private static void RunProductsDemo2(ProdcutsDemo2 prodcutsDemo, Func<Product, bool> action = null)
        {
            if (action != null)
            {
                prodcutsDemo.GenerateProducts(action)
                    .SortAndDisplayProducts(new ProductNameComparerV2());
                    //.SortAndDisplayProducts(new ProductPriceComparer());
            }
            else
            {
                prodcutsDemo
                    .GenerateProducts()
                    .SortAndDisplayProducts(new ProductNameComparerV2());
                    //.SortAndDisplayProducts(new ProductPriceComparer());
            }
        }
    }

}
