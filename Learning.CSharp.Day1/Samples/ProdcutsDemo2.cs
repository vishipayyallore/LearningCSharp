using System;
using System.Collections.Generic;
using Learning.CSharp.DataModels;
using Learning.CSharp.Day1.Infrastructure;

namespace Learning.CSharp.Day1.Samples
{
    public class ProdcutsDemo2
    {

        #region Variables.
        private List<Product> _products;
        #endregion

        public ProdcutsDemo2()
        {
            GenerateProducts();
        }

        #region Methods
        public ProdcutsDemo2 GenerateProducts(Func<Product, bool> action = null)
        {
            _products = new List<Product>();
            _products.AddRange(ProductsHelper.RetrieveProducts((action)));
            return this;
        }

        public ProdcutsDemo2 SortAndDisplayProducts(IComparer<Product> comparer)
        {
            _products.Sort(comparer);
            Console.WriteLine("\n\n");
            foreach (var product in _products)
            {
                Console.WriteLine(product);
            }
            return this;
        }

        public ProdcutsDemo2 SortAndDisplayProducts()
        {
            _products.Sort((product1, product2) => product1.Price.CompareTo(product2.Price));
            Console.WriteLine("\n\n");
            foreach (var product in _products)
            {
                Console.WriteLine(product);
            }
            return this;
        }
        #endregion

    }
}