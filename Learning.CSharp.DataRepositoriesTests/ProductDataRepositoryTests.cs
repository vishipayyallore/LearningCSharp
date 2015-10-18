using System;
using System.Collections;
using System.Linq;
using Learning.CSharp.DataModels;
using Learning.CSharp.DataRepositories;
using Learning.CSharp.Utilities;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Learning.CSharp.DataRepositoriesTests
{
    [TestClass]
    public class ProductDataRepositoryTests
    {
        [TestMethod]
        public void WhenAProduct_IsCreated()
        {
            var productsRepository = new ProductsRepository();
            var currencyGenerator = new CurrencyGenerator();
            var product = new Product
            {
                Name = NameGenerator.GenerateName(),
                Price = currencyGenerator.GenerateAmount()
            };
            var results = productsRepository.Add(product).Result;
            Console.WriteLine(results);
        }

        [TestMethod]
        public void When_ProductsList_IsRetrieved()
        {
            var productsArrayList = new ArrayList();
            var productsRepository = new ProductsRepository();
            var results = productsRepository.List.Result;
            productsArrayList.AddRange(results);
            foreach (var product in productsArrayList)
            {
                Console.WriteLine(product.ToString());
            }
        }

        [TestMethod]
        public void When_10Products_AreCreated()
        {
            var productsRepository = new ProductsRepository();
            var currencyGenerator = new CurrencyGenerator(maximumValue: 15000.0);
            for (var iCtr = 0; iCtr < 1000; iCtr++)
            {
                var product = new Product
                {
                    Name = NameGenerator.GenerateName(),
                    Price = currencyGenerator.GenerateAmount()
                };
                var results = productsRepository.Add(product).Result;
                Console.WriteLine(results);
            }
        }

        [TestMethod]
        public void When_ProductsList_Greaterthan500_IsRetrieved()
        {
            var productsArrayList = new ArrayList();
            var productsRepository = new ProductsRepository();
            var results = productsRepository.GetPrdocuts(x => (x.Price > 1800 && x.Price<3000));
            //var refined = results.Where(x => x.Price > 700).ToList();
            //productsArrayList.AddRange(results);
            foreach (var product in results)
            {
                Console.WriteLine(product.ToString());
            }
        }
    }
}
