using System;
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

            var product = new Product
            {
                Name = NameGenerator.GenerateName(),
                Price = 102.3M
            };
            var results = productsRepository.Add(product).Result;
            Console.WriteLine(results);
        }
    }
}
