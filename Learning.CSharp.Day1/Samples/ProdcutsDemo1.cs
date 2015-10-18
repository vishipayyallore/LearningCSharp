using System;
using System.Collections;
using Learning.CSharp.DataModels;
using Learning.CSharp.Day1.Infrastructure;

namespace Learning.CSharp.Day1.Samples
{
    public class ProdcutsDemo1
    {

        #region Variables.
        private ArrayList _products;
        #endregion

        public ProdcutsDemo1()
        {
            GenerateProducts();
        }

        #region Methods
        public ProdcutsDemo1 GenerateProducts(Func<Product, bool> action  = null)
        {
            _products = new ArrayList();
            _products.AddRange(ProductsHelper.RetrieveProducts((action)));
            return this;
        }

        public ProdcutsDemo1 SortAndDisplayProducts(IComparer comparer)
        {
            _products.Sort(comparer);
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