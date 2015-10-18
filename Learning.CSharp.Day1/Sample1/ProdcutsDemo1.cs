using System;
using System.Collections;
using Learning.CSharp.DataRepositories;

namespace Learning.CSharp.Day1.Sample1
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
        public ProdcutsDemo1 GenerateProducts()
        {
            _products = new ArrayList();
            var productsRepository = new ProductsRepository();
            _products.AddRange(productsRepository.List);
            return this;
        }

        public ProdcutsDemo1 SortAndDisplayProducts()
        {
            _products.Sort(new ProductNameComparer());
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