using System;
using System.Collections;
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
            var results = productsRepository.List;
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
            var currencyGenerator = new CurrencyGenerator();
            for (var iCtr = 0; iCtr < 10; iCtr++)
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
    }
}
